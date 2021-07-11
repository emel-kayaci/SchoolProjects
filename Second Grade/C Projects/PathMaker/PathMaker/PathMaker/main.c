#include<stdio.h>
#include <stdlib.h>
#include <dirent.h>
#include <unistd.h>
#include <conio.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <direct.h>
#include <string.h>
#include <ctype.h>

int isKeyword(char ch, FILE *fp)
{
    char substring[6]={0};
    char keywords[4][6] = {"make","go","if","ifnot"};
    int i=0;
    while(isalpha(ch)){
        strncat(substring,&ch,1);
        ch = fgetc(fp);

    }
    if(ch=='<'){
        fseek(fp,-1,SEEK_CUR);
    }

    printf("\nKOMUT: %s\n",substring);


    if(strcasecmp(substring,keywords[0])==0){ //MAKE KODU
        char* old_dir=getcwd(NULL,0);                       //Go fonskiyonu disinda her fonk icin. OLD PATH'a donmek zorunludur.
        pathfunc(ch,fp,substring);
        _chdir(old_dir);
    }
    else if(strcasecmp(substring,keywords[1])==0){ //GO KODU
        pathfunc(ch,fp,substring);
    }
    else if(strcasecmp(substring,keywords[2])==0){ //IF KODU
       char* old_dir=getcwd(NULL,0);
       pathfunc(ch,fp,substring);
       _chdir(old_dir);
    }
    else if(strcasecmp(substring,keywords[3])==0){ //IFNOT KODU
        char* old_dir=getcwd(NULL,0);
       pathfunc(ch,fp,substring);
       _chdir(old_dir);
    }
    else{
        printf("Syntax Error, undefined Keyword.");
    }
    printf("\nDIRECTORY KONUMU: %s\n",getcwd(NULL,0));
    printf("------------------------------------------------------------------");
    return 0;
}

void pathfunc(char ch,FILE *fp,char substring[]){

    char path_substring[100] = {0};

    ch = fgetc(fp);
    if(ch==' ' || ch=='<'){
        while(ch==' ' || ch=='\t'){
            ch=fgetc(fp);
            if(ch=='<'){
                break;
            }
            else if(ch!=' ' || ch!='\t'){
                printf("Syntax Error, Invalid Syntax for Make Func.");
                exit(0);
            }
        }
        ch=fgetc(fp);

       while(ch!='>'){                                          //Butun path'in alinmasi icin yapildi
            if(isalnum(ch) || ch=='_' || ch=='*' || ch=='/'){
            strncat(path_substring,&ch,1);
            ch=fgetc(fp);
            }
            else if(ch==' '){
                printf("SPACE IS NOT ALLOWED FOR DIRECTORY NAMES\n");
                exit(0);
            }
            else{
                printf("INVALID SYNTAX FOR DIRECTORY PATH");        //eger directory'ler arasi bosluk varsa hata mesaji
                exit(0);
            }
       }


            if(ch=='>'){
                ch=fgetc(fp);
                if(strcmp(substring,"go")==0 || strcmp(substring,"make")==0) {
                while(ch == ' ' || ch=='\t'){
                    ch=fgetc(fp);
                    if(ch==';'){
                       break;
                    }
                    else if(ch==' ' || ch=='\t'){
                        continue;
                    }
                    else{
                    printf("END OF LINE EXPECTED FOR FUNC");     //make ve go terimleri için end of line kontrolü
                        exit(0);

                    }
                }
            }
            }
            printf("Path: %s\n\n",path_substring);


        int if_kontrol=0;                               //PATH'I TOKENIZER YARDIMI ILE AYRIMA ISLEMLERI
        char *ayrac="/";
        char *uste_cik="*";
        char *dizin = strtok(path_substring,ayrac);

        if(dizin==NULL){
            printf("NULL Path Error... Please Fix your Path Commands.\n");
            exit(0);
        }

        while(dizin!=NULL){
            if(strcmp(dizin,"")==0){
                printf("DIZIN BOS OLAMAZ, DUZELTIN");
                exit(0);
            }
            if(strcmp(dizin,uste_cik)==0){ //USTE CIK= * ICIN GEREKLI FONK KULLANILDI
                _chdir("..");
                printf("We are in upper Directory.\n");

                char* us="Users";
                char* user=getcwd(NULL,0);
                char* compare=strstr(user,us);

                if(compare==NULL){
                    printf("USERS KLASORU GECILEMEZ! \n"); //USER'IN USTUNE CIKILAMAMA DURUMU
                    exit(0);

                }
            }
            else{

               //UYGUN FONK. BLUNUP ISLEMLERIN YAPILMASI

              if(strcmp(substring,"go")==0){
                    if(_chdir(dizin)==0){
                        printf("We are in Directory %s.\n",dizin);
                        _chdir(dizin);
                    }
                }
              else if(strcmp(substring,"make")== 0){
                    if(mkdir(dizin)==0){
                        printf("Directory %s created Succesfully\n",dizin);
                        _chdir(dizin);
                    }
                    else{
                        if(_chdir(dizin)==0){
                            printf("There is already a folder named %s... \n",dizin);
                        }
                        else{
                        printf("Directory creation error.\n");
                        }
                    }

               }

               else if(strcmp(substring,"if")== 0){

                        if(_chdir(dizin)==0){
                            printf("If Condition Exist for %s.\n",dizin);
                            _chdir(dizin);
                        }
                        else{
                            printf("If  Condition Doesn't Exist for %s.\n",dizin);
                            if_kontrol=1;
                            break;
                        }

              }
              else if(strcmp(substring,"ifnot")== 0){

                        if(_chdir(dizin)==0){
                            printf("Ifnot Condition Doesn't Exist for %s.\n",dizin);
                            if_kontrol=1;
                            break;

                        }
                        else{
                            printf("Ifnot Condition Exist for %s.\n",dizin);

                        }
              }

            }
        dizin = strtok(NULL,ayrac);

        }
            if(if_kontrol){

                while(ch!='}'){
                    ch=fgetc(fp);
                }
            }

    }
    else{
        printf("Syntax Error.");
        exit(0);
    }


}


void main()
{
    FILE *fp;

     char str[20];
     printf( "Enter the File Name (source not included.) :");
     gets(str);

     strcat(str,".pmk.txt");


     if((fp = fopen(str, "r")) == NULL)
    {
        printf("Could not open the file.");
        exit(0);
    }

    else
    {
        int sol_bracket_say=0;
        int sag_bracket_say=0;
        printf("\nFILE OPENED.\n");

        printf("\nBASLANGIC DIRECTORY KONUMU: %s\n",getcwd(NULL,0));
        while(!feof(fp))
        {
         char ch = fgetc(fp);

         if(ch=='{'){
                sol_bracket_say++;
                continue;
            }
         else if(ch=='}'){
                sag_bracket_say++;
                continue;
            }
         else if(isalpha(ch)){ //Programda alfabetik olarak BASLAYABILEN tek sey fonksiyonlardir.
            isKeyword(ch,fp);
            }
         else if(ch==' ' || ch=='\n' || ch=='\0' ||ch=='\t'){ //Indentation yapilabilmesi icin \t eklendi.
            continue;
         }
         else if(ch == EOF){

            if(sag_bracket_say!=sol_bracket_say){
                printf("\nBLOKLAMA HATANIZ VAR, LUTFEN DUZELTIN...\n");     //PROGRAM BRACKET ESIT DEGILSE BILE CALISIYOR, AMA HATA MESAJI VERIYOR.
            }
            else{
            printf("\n\nTERMINATED SUCCESSFULLY.\n");
            }
         }
         else{

            printf("Syntax Error. Invalid input.");
            exit(0);
         }


        }
        fclose(fp);
    }
}
