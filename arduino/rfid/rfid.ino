#include <SPI.h>
#include <MFRC522.h>
#define RST_PIN 9
#define SS_PIN 10
byte readCard[4];
int successRead;
int led = 7;
MFRC522 mfrc522(SS_PIN, RST_PIN);
MFRC522::MIFARE_Key key;
void setup()
{ 
Serial.begin(9600); 
SPI.begin(); 
mfrc522.PCD_Init(); 
pinMode(led, OUTPUT);
}
void loop(){
        do { 
      //okuma başarılı olana kadar getID fonksiyonunu çağır 
      successRead = getID();
      } 
      while (!successRead);
      digitalWrite(led, HIGH);
      delay(2000);
      digitalWrite(led, LOW); 
}
int getID() {
//yeni bir kart okunmadıysa 0 döndür 
if (!mfrc522.PICC_IsNewCardPresent()) 
{return 0;} 
if (!mfrc522.PICC_ReadCardSerial()) 
{return 0;} 
//Serial.print("Kart UID’si:"); 
//kartın UID’sini byte byte oku ve seri monitöre yaz 
for (int i=0; i<mfrc522.uid.size; i++) 
{ 
readCard[i] = mfrc522.uid.uidByte[i]; 
Serial.print(readCard[i], HEX); 
} 
Serial.println(""); 
//kart okumayı durdur ve 1 döndür (okuma başarılı) 
mfrc522.PICC_HaltA(); 
return 1;
}
