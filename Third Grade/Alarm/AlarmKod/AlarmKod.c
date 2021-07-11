#include<reg51.h> 

sbit dec=P2^5;

sbit hour=P2^6;
sbit min=P2^7;

sbit buzzer=P3^3;

sbit day=P3^1;

sbit month=P3^2;
sbit year=P3^4;


sbit rs=P2^1; //LCD command pini (lcd içindeki direnci secer)
sbit rw=P2^2; //LCD'ye bilgileri yazmak için kullanilan pin
sbit en=P2^3; //Tarihi ayarlamak icin kullanilan LCD command pini

sfr lcddata=0x90; //P2=LCD veri pini

sbit alarm=P3^7;
int button_flag;
int h,m,s,hA, mA, y,mo,d,y1,y2,y3,y4,mo1,mo2,d1,d2,h1,h2,h3,h4,m1,m2,m3,m4,s1,s2,i,j,k,space;
unsigned char con; //Alarm kontrol degiskeni
unsigned char array[]={'0','1','2','3','4','5','6','7','8','9'};


/*******************TIMER FONKSIYONU********************/
int z = 0;
void timer() {
	TMOD = 0X01;
	TH0 = 0XFC; // 1 ms'lik timer lar
	TL0 = 0X18;
	
	// Interrupt
	ET0 = 1;
	EA = 1;
	
	TR0 = 1; //Timer start
	
	while(TF0 == 0); //Overflow kontrolü
	TR0 = 0; //Timer stop
	TF0 = 0; //Clear flag
}

/*******************INTERRUPT SERVIS RUTINI********************/
void Timer0_ISR(void) interrupt 1
{
	if(h==hA && m==mA && alarm==0) {
		con=1;
		buzzer=1;
	}
	else {
		buzzer=0;
		con=0;
	}				
	TF0 = 0; //clear interupt flag
}

/******************LCD KOMUT FONKSIYONU***************/
void command(unsigned int  cmd) {
	lcddata=cmd; //veri pinine veriler yüklenir
	rs=0;
	rw=0;
	en=1;
	timer();
	en=0;
}

/***************LCD GÖRÜNTÜLEME FONKSIYONU*******************/
void ldcdisplaydata(unsigned char s) {
	lcddata=s;
	rs=1;
	rw=0;
	en=1;
	timer();
	en=0;
}
	
/***********************ANA PROGRAM***********************/
void main() {
	

	command(0x38); //2 satir ve 5x7'lik matris icin LCD komutu
	command(0x0c); 
	command(0x06); //Cursor'i saga kaydirmak icin LCD komutu
	y=2021; //baslangic tarihi
	mo=7;
	d=1;
  button_flag = 0;
	m=-1;
	h=-1;
	while(1) 
	{
		hA=0;
		mA=1;
		con=0;
		
					for(s=0;s<=59;s++) { 
			
						if(mo==1 || mo==3 || mo==5 || mo==7 || mo==8 || mo==10 || mo==12) {
								d=31;
							}		
							else if(mo==2) {
								if((y%4)==0) {
									d=29;
								} 
								else {
									d=28;
								}
							}
							else {
								d=30;
							}
							
						if(s==0 && button_flag==0) { //dakikayi arttir
							m++; 
							if(m>59) { 
								m=0;
						  }
						}
							
						 if(m==0 && s==0 && button_flag==0) { //saati arttir
								h++; 
								if(h==24) { 
									h=0;
								} 
							}
							
							if(h==0 && m==0 && s==0 && button_flag==0) { //gunu arttir
								i++;
							  if(i>d) {
									i=1;
							  } 
							}

							if(h==0 && m==0 && s==0 && i==1 && button_flag==0) {
								if(mo<12) {
									mo++;
								} else {
									mo=1;
								}
							}
							
							button_flag=0;
							
							if(alarm==0) {
								
								h3 = hA/10; //alarmda saati gostermek icin
								h4 = hA%10;
								
								m3 = mA/10; //dakikayi gostermek icin
								m4 = mA%10;
								
								command(0x94); //lcd ikinci satirin ilk pozisyonu
								ldcdisplaydata('A');
								ldcdisplaydata('L');
								ldcdisplaydata('A');
								ldcdisplaydata('R');
								ldcdisplaydata('M');
								ldcdisplaydata(':');
								ldcdisplaydata(' ');
								ldcdisplaydata(array[h3]);
								ldcdisplaydata(array[h4]);
								ldcdisplaydata(' ');
								ldcdisplaydata(':');
								ldcdisplaydata(' ');					
								ldcdisplaydata(array[m3]);
								ldcdisplaydata(array[m4]);
						 }	
							else {
								command(0x94); //lcd ikinci satirin ilk pozisyonu
								for(space=1;space<=20;space++) {
									ldcdisplaydata(' ');
								}
							}
			
						if(alarm==0 && hour==0 && dec==1) { //alarm saatini arttirma
							hA++;
							if(hA==24) {
								hA=0;
							} 
						}
						
						else if(alarm==0 && hour==0 && dec==0) { //alarm saatini azaltma
							if(hA>0) {
								hA--;  
							} else {
								hA=23;
							}
						}
						
						else if(alarm==0 && min==0 && dec==1) { //alarm dakikasini arttirma
							mA++; 
							if(mA>60) { //saati sifirla
								mA=0;
							}
						}	
						
						else if(alarm==0 && min==0 && dec==0) { //alarm dakikasini azaltma
							if(mA>0) {
								mA--;  
							} else {
								mA=60;
							}
						}
			
						y1 = y/1000;
						j = y%1000;  //yili gostermek icin 
						y2 = j/100;
						k = j%100;
						y3 = k/10;
						y4 = k%10;
									
						mo1 = mo/10; //ayi gostermek icin 
						mo2 = mo%10;
									
						d1 = i/10; //gunu gostermek icin
						d2 = i%10;
						
						h1 = h/10; //saati gostermek icin
						h2 = h%10;
					
						m1 = m/10; //dakikayi gostermek icin
						m2 = m%10;
				
						s1 = s/10; //saniyeyi gostermek icin
						s2 = s%10;
									
						command(0x80); //lcd'nin ilk satirda ilk pozisyonu
						ldcdisplaydata('D');
						ldcdisplaydata('A');
						ldcdisplaydata('T');
						ldcdisplaydata('E');
						ldcdisplaydata(':');
						ldcdisplaydata(' ');
						ldcdisplaydata(array[d1]);
						ldcdisplaydata(array[d2]);
						ldcdisplaydata(' ');
						ldcdisplaydata('-');
						ldcdisplaydata(' ');					
						ldcdisplaydata(array[mo1]);
						ldcdisplaydata(array[mo2]);
						ldcdisplaydata(' ');
						ldcdisplaydata('-');
						ldcdisplaydata(' ');		
						ldcdisplaydata(array[y1]);
						ldcdisplaydata(array[y2]);
						ldcdisplaydata(array[y3]);
						ldcdisplaydata(array[y4]);
									
						command(0xc0); //lcd ikinci satirin ilk pozisyonu
						ldcdisplaydata('T');
						ldcdisplaydata('I');
						ldcdisplaydata('M');
						ldcdisplaydata('E');
						ldcdisplaydata(':');
						ldcdisplaydata(' ');
						ldcdisplaydata(array[h1]);
						ldcdisplaydata(array[h2]);
						ldcdisplaydata(' ');
						ldcdisplaydata(':');
						ldcdisplaydata(' ');					
						ldcdisplaydata(array[m1]);
						ldcdisplaydata(array[m2]);
						ldcdisplaydata(' ');
						ldcdisplaydata(':');
						ldcdisplaydata(' ');
						ldcdisplaydata(array[s1]);
						ldcdisplaydata(array[s2]);
						

						if(con==1){
							if(s%2==0){
								command(0xE1);
								ldcdisplaydata('A');
								ldcdisplaydata('L');
								ldcdisplaydata('A');
								ldcdisplaydata('R');
								ldcdisplaydata('M');
							}
							else{
								command(0xE1);
								ldcdisplaydata(' ');
								ldcdisplaydata(' ');
								ldcdisplaydata(' ');
								ldcdisplaydata(' ');
								ldcdisplaydata(' ');
							}
						}
						else{
								command(0xE1);
								ldcdisplaydata(' ');
								ldcdisplaydata(' ');
								ldcdisplaydata(' ');
								ldcdisplaydata(' ');
								ldcdisplaydata(' ');
						}

						for (z = 0; z < 1000; z++) 
						{
							timer();
						}		
					
						if(alarm==1 && hour==0 && dec==1){ //saati arttirma
							h++; 
							s=-1; //saat ayarlandiktan sonra saniyeyi sifirlar
							if(h==24) { //saati sifirla
								h=0;
								s=-1; 
							}
							button_flag=1;
						}				
						
						else if(alarm==1 && hour==0 && dec==0) { //saati azaltma
							if(h>0) {
							h--; 
							}else {
								h=23;
							}
							s=-1;
							button_flag=1;
						}				
						
						else if(alarm==1 && min==0 && dec==1) { //dakikayi arttirma
							m++; 
							s=-1; //saat ayarlandiktan sonra saniyeyi sifirlar
							if(m>59) { //saati sifirla
							m=0;
							s=-1; 
						  }
							button_flag=1;
						}	
				
						else if(alarm==1 && min==0 && dec==0) { //dakikayi azaltma
							if(m>0) {
								m--; 
							} else {
								m=59;
							}
							s=-1; 
							button_flag=1;
						}
						else if(day==0 && dec==1) { //gunleri arttirir
							i++;
							if(i>d) {
								i=1;
							}
						  button_flag=1;
						}			
						else if(day==0 && dec==0) { //gunleri azaltir
							if(i>1) {
								i--;
							} else {
								i=d;
							}
							button_flag=1;
						}		
						else if(month==0 && dec==1) { //aylari arttirir
							i=1;
							if(mo<12) {
								mo++;
							} else {
								mo=1;
							}
							button_flag=1;
						}		
						else if(month==0 && dec==0) { //aylari azaltir
							i=1;
							if(mo>1) {
								mo--;
							} else{
								mo=12;
							}
							button_flag=1;
						}	
						else if(year==0 && dec==1) { //yili arttirir
							y++;
							button_flag=1;
						}	
						else if(year==0 && dec==0) { //yili azaltir
							y--;
							button_flag=1;
						}	
				}
							
			}
		}