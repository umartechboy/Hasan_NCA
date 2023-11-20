#include <Arduino.h>

#define NoOfChannels 6

long lastDebug = 0;
int lastAnalogRead[NoOfChannels] = {0};
int deltas[NoOfChannels] = {0};

long gains[NoOfChannels] = {10};
long dampings[NoOfChannels] = {4};
long maxes[NoOfChannels] = {10000};


void setup()
{
  Serial.begin(115200);
  for(int i = 1 ; i < NoOfChannels; i++){
    gains[i] = gains[0];
    dampings[i] = dampings[0];
    maxes[i] = maxes[0];

  }
}

void loop()
{
  if (Serial.available()){
    String str = Serial.readStringUntil('\n');
    String com = str.substring(0, str.indexOf("="));
    long * array = 0;
    String arg = str.substring(str.indexOf("=") + 1);
    if (com.startsWith("gain"))
      array = gains;
    else if (com.startsWith("max"))
      array = maxes;
    else if (com.startsWith("damping"))
      array = dampings;
    else { // common commands

    }
    if (array != 0){
      int index = com.substring(com.indexOf(" ") + 1).toInt();
      if (index < 0 || index >= NoOfChannels)
        return;
      int lastValue = array[index];
      arg.trim();
      if (arg != "")
        lastValue = arg.toInt();
      array[index] = lastValue;
    }
  }
  for (int i = 0; i < NoOfChannels; i++)
  {
    // put your main code here, to run repeatedly:
    int currentAnalogRead = analogRead(A0 + i) * gains[i];
    deltas[i] += abs(currentAnalogRead - lastAnalogRead[i]);
    lastAnalogRead[i] = currentAnalogRead;
    deltas[i] -= dampings[i];
    if (deltas[i] < 0)
      deltas[i] = 0;
    else if (deltas[i] > maxes[i])
      deltas[i] = maxes[i];
  }
  if (millis() - lastDebug > 100)
  {
    Serial.print("deltas:");
    for (int i = 0; i < NoOfChannels; i++)
    {
      Serial.print(deltas[i]);
      Serial.print(",");
    }
    Serial.println();
    lastDebug = millis();
  }
}
