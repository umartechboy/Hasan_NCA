#include <Arduino.h>

void setup() {
  Serial.begin(115200);
}

long  lastDbug  = 0;
int lastA0 = 0;
int delta = 0;
void loop() {
  // put your main code here, to run repeatedly:
  int currentA0 = analogRead(A0) * 10;
  delta += abs(currentA0 - lastA0);
  lastA0 = currentA0;
  delta -= 4;
  if(delta < 0)
    delta = 0;
  else if (delta > 10000)
    delta = 10000;

  if (millis() - lastDbug > 100){
    Serial.println(delta);
    //Serial.print(',');
    //Serial.println((delta > 500) ? 5000 : 0);
    lastDbug = millis();
  }

}
