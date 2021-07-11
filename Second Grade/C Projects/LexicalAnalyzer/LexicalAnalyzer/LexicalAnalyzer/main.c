#include <stdio.h>
#include <ctype.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

bool isKeyword(char substring[])
{
    int check = false;
    char keywords[18][10] = {"break", "case", "char", "const", "continue", "do", "else", "enum", "float", "for", "goto",
                             "if",
                             "int", "long", "record", "return", "static", "while"
                            };

    for (int i = 0; i < 18; i++)
    {
        if ((strcasecmp(keywords[i],substring)) == 0)
        {
            check = true;
            break;
        }
    }
    return check;
}

void isNumber(char ch, FILE *fp,FILE *fw)
{
    char substring[10] = {0};
    int i = 0;

    while(isdigit(ch))
    {
        substring[i] = ch;
        ch = fgetc(fp);
        if(ch==EOF)
        {
            break;
        }
        if(strlen(substring) > 10)
        {
            fprintf(fw,"Error! Maximum integer size is not more than 10 digits.\n");
            break;
        }
        i++;
    }
    fseek(fp,-1,SEEK_CUR);
    if(strlen(substring) > 10)
    {
        while(isdigit(ch))
        {
            ch = fgetc(fp);
        }
    }
    else
    {
        fprintf(fw,"IntConst(%s)\n", substring);
    }
}

int isIdentifier(char ch, FILE *fp,FILE *fw)
{
    char substring[20] = {0};
    int i = 0;

    while((isalnum(ch) || ch == '_'))
    {
        substring[i] = ch;
        ch=fgetc(fp);
        if(strlen(substring) > 20)
        {
            fprintf(fw, "Error! Maximum identifier size is not more than 20 digits.\n");
            break;
        }
        i++;
    }

    for(int j=0; j<strlen(substring);j++){
        substring[j]=tolower(substring[j]);
    }

    if(strlen(substring) > 20)
    {
        while((isalnum(ch) || ch == '_'))
        {
            ch = fgetc(fp);
        }
    }
    else if(isKeyword(substring))
    {
        fprintf(fw,"Keyword(%s)\n", substring);
    }
    else
    {
        fprintf(fw,"Identifier(%s)\n", substring);
    }

}

void isBracket(char ch, FILE *fp,FILE *fw)
{
    if (ch == '(')
    {
        if(fgetc(fp)== '*')
        {
            isComment(fp, fw);
        }
        else
        {
            fprintf(fw,"LeftPar\n");
            fseek(fp,-1,SEEK_CUR);
        }
    }
    else if (ch == ')')
        fprintf(fw,"RightPar\n");
    else if (ch == '[')
        fprintf(fw,"LeftSquareBracket\n");
    else if (ch == ']')
        fprintf(fw,"RightSquareBracket\n");
    else if (ch == '{')
        fprintf(fw,"LeftCurlyBracket\n");
    else if (ch == '}')
        fprintf(fw,"RightCurlyBracket\n");

}

void isComment(FILE *fp, FILE *fw)
{
    int flag = 1;
    while(flag)
    {
        char ch = fgetc(fp);
        if(ch == '*' && fgetc(fp) == ')')
        {
            flag = 0;
        }
        else if (ch == EOF)
        {
            fprintf(fw, "Error! End of file for comment.");
            flag = 0;
        }
    }
}

void resizeArray(char substring, int capacity)
{
    capacity *= 2;
    substring = (int *) realloc(substring, capacity * sizeof(int));
}

void isStringConst(FILE *fp,FILE *fw)
{
    int capacity = 10; //initial capacity
    char *substring = (char *)calloc(capacity, sizeof(char));

    int i = 0;
    char ch = fgetc(fp);
    while(ch != '"')
    {
        substring[i] = ch;
        ch = fgetc(fp);
        i++;
        if (ch == EOF)
        {
            fprintf(fw, "Error! End of file for string.");
            break;
        }
    }
    if(ch != EOF)
    {
        fprintf(fw, "StringConst(%s)\n", substring);
    }
}

void isOperator(char ch, FILE *fp,FILE *fw)
{
    if(ch=='-' || ch=='+'|| ch=='/'|| ch=='*'|| ch==':')
    {
        if(ch=='+')
        {
            if(fgetc(fp)=='+')
                fprintf(fw,"Operator(++)\n");
            else
            {
                fprintf(fw, "Operator(%c)\n",ch);
                fseek(fp,-1,SEEK_CUR);
            }
        }

        else if(ch=='-')
        {
            if(fgetc(fp)=='-')
                fprintf(fw,"Operator(--)\n");
            else
            {
                fprintf(fw,"Operator(%c)\n",ch);
                fseek(fp,-1,SEEK_CUR);
            }
        }
        else if(ch==':')
        {
            if(fgetc(fp)=='=')
                fprintf(fw,"Operator(:=)\n");
            else
            {
                fseek(fp,-1,SEEK_CUR);
            }
        }
        else if(ch=='/' || ch== '*')
        {
            fprintf(fw,"Operator(%c)\n",ch);
        }
        else
        {
            fseek(fp,-1,SEEK_CUR);
        }
    }
}

int main()
{
    FILE *fp;
    FILE *fw;

    fw=fopen("code.lex.txt","w+");

    if((fp = fopen("code.psi.txt", "r")) == NULL)
    {
        fprintf(fw,"Could not open the file.");
        exit(0);

    }
    else
    {
        while(!feof(fp))
        {

            char ch = fgetc(fp);

            if (isalpha(ch))
            {
                if(fgetc(fp)==EOF)
                {
                    break;
                }
                else
                {
                    fseek(fp,-1,SEEK_CUR);
                }
                isIdentifier(ch, fp,fw);
                fseek(fp,-1,SEEK_CUR);
            }
            else if(isdigit(ch))
            {
                isNumber(ch, fp,fw);
            }
            else if(ch == '"')
            {
                isStringConst(fp,fw);
            }
            else if (ch == ';')
            {
                fprintf(fw,"EndOfLine\n");
            }
            else
            {
                isBracket(ch, fp,fw);
                isOperator(ch,fp,fw);
            }
            if(fgetc(fp)==EOF)
                break;
            else
            {
                fseek(fp,-1,SEEK_CUR);
            }

        }
    }
    fclose(fw);
    fclose(fp);
    return 0;
}
