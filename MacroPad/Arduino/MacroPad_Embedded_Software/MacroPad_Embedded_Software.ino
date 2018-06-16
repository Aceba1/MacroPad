#include <digitalWriteFast.h>

void setup()
{
  Serial.begin(500000);
  while (!Serial.available())
  {
    delay(100);
  }
  Serial.println("macropad_connect");
  while (Serial.available())
  {
    Serial.read ();
  }
}

void loop()
{
  if (Serial.available() > 1)
  {
    int r1 = Serial.read();
    int r2 = Serial.read();
    switch (r2)
    {
      case 0:
        pinModeFastInputSwitch(r1);
        break;
      case 1:
        pinModeFastOutputSwitch(r1);
        digitalWriteFastLowSwitch(r1);
        break;
      case 2:
        pinModeFastOutputSwitch(r1);
        digitalWriteFastHighSwitch(r1);
        break;
    }
  }
}
void pinModeFastInputSwitch(int value)
{
  switch (value)
  {
    case 2:
      pinModeFast(2,INPUT);
    break;
    case 3:
      pinModeFast(3,INPUT);
    break;
    case 4:
      pinModeFast(4,INPUT);
    break;
    case 5:
      pinModeFast(5,INPUT);
    break;
    case 6:
      pinModeFast(6,INPUT);
    break;
    case 7:
      pinModeFast(7,INPUT);
    break;
    case 8:
      pinModeFast(8,INPUT);
    break;
    case 9:
      pinModeFast(9,INPUT);
    break;
    case 10:
      pinModeFast(10,INPUT);
    break;
    case 11:
      pinModeFast(11,INPUT);
    break;
    case 12:
      pinModeFast(12,INPUT);
    break;
    case 13:
      pinModeFast(13,INPUT);
    break;
    case 14:
      pinModeFast(14,INPUT);
    break;
    case 15:
      pinModeFast(15,INPUT);
    break;
    case 16:
      pinModeFast(16,INPUT);
    break;
    case 17:
      pinModeFast(17,INPUT);
    break;
    case 18:
      pinModeFast(18,INPUT);
    break;
    case 19:
      pinModeFast(19,INPUT);
    break;
    case 20:
      pinModeFast(20,INPUT);
    break;
    case 21:
      pinModeFast(21,INPUT);
    break;
    case 22:
      pinModeFast(22,INPUT);
    break;
    case 23:
      pinModeFast(23,INPUT);
    break;
    case 24:
      pinModeFast(24,INPUT);
    break;
    case 25:
      pinModeFast(25,INPUT);
    break;
    case 26:
      pinModeFast(26,INPUT);
    break;
    case 27:
      pinModeFast(27,INPUT);
    break;
    case 28:
      pinModeFast(28,INPUT);
    break;
    case 29:
      pinModeFast(29,INPUT);
    break;
    case 30:
      pinModeFast(30,INPUT);
    break;
    case 31:
      pinModeFast(31,INPUT);
    break;
    case 32:
      pinModeFast(32,INPUT);
    break;
    case 33:
      pinModeFast(33,INPUT);
    break;
    case 34:
      pinModeFast(34,INPUT);
    break;
    case 35:
      pinModeFast(35,INPUT);
    break;
    case 36:
      pinModeFast(36,INPUT);
    break;
    case 37:
      pinModeFast(37,INPUT);
    break;
    case 38:
      pinModeFast(38,INPUT);
    break;
    case 39:
      pinModeFast(39,INPUT);
    break;
    case 40:
      pinModeFast(40,INPUT);
    break;
    case 41:
      pinModeFast(41,INPUT);
    break;
    case 42:
      pinModeFast(42,INPUT);
    break;
    case 43:
      pinModeFast(43,INPUT);
    break;
    case 44:
      pinModeFast(44,INPUT);
    break;
    case 45:
      pinModeFast(45,INPUT);
    break;
    case 46:
      pinModeFast(46,INPUT);
    break;
    case 47:
      pinModeFast(47,INPUT);
    break;
    case 48:
      pinModeFast(48,INPUT);
    break;
    case 49:
      pinModeFast(49,INPUT);
    break;
    case 50:
      pinModeFast(50,INPUT);
    break;
    case 51:
      pinModeFast(51,INPUT);
    break;
    case 52:
      pinModeFast(52,INPUT);
    break;
    case 53:
      pinModeFast(53,INPUT);
    break;
    case 54:
      pinModeFast(54,INPUT);
    break;
    case 55:
      pinModeFast(55,INPUT);
    break;
    case 56:
      pinModeFast(56,INPUT);
    break;
    case 57:
      pinModeFast(57,INPUT);
    break;
    case 58:
      pinModeFast(58,INPUT);
    break;
    case 59:
      pinModeFast(59,INPUT);
    break;
  }
}
void pinModeFastOutputSwitch(int value)
{
  switch (value)
  {
    case 2:
      pinModeFast(2,OUTPUT);
    break;
    case 3:
      pinModeFast(3,OUTPUT);
    break;
    case 4:
      pinModeFast(4,OUTPUT);
    break;
    case 5:
      pinModeFast(5,OUTPUT);
    break;
    case 6:
      pinModeFast(6,OUTPUT);
    break;
    case 7:
      pinModeFast(7,OUTPUT);
    break;
    case 8:
      pinModeFast(8,OUTPUT);
    break;
    case 9:
      pinModeFast(9,OUTPUT);
    break;
    case 10:
      pinModeFast(10,OUTPUT);
    break;
    case 11:
      pinModeFast(11,OUTPUT);
    break;
    case 12:
      pinModeFast(12,OUTPUT);
    break;
    case 13:
      pinModeFast(13,OUTPUT);
    break;
    case 14:
      pinModeFast(14,OUTPUT);
    break;
    case 15:
      pinModeFast(15,OUTPUT);
    break;
    case 16:
      pinModeFast(16,OUTPUT);
    break;
    case 17:
      pinModeFast(17,OUTPUT);
    break;
    case 18:
      pinModeFast(18,OUTPUT);
    break;
    case 19:
      pinModeFast(19,OUTPUT);
    break;
    case 20:
      pinModeFast(20,OUTPUT);
    break;
    case 21:
      pinModeFast(21,OUTPUT);
    break;
    case 22:
      pinModeFast(22,OUTPUT);
    break;
    case 23:
      pinModeFast(23,OUTPUT);
    break;
    case 24:
      pinModeFast(24,OUTPUT);
    break;
    case 25:
      pinModeFast(25,OUTPUT);
    break;
    case 26:
      pinModeFast(26,OUTPUT);
    break;
    case 27:
      pinModeFast(27,OUTPUT);
    break;
    case 28:
      pinModeFast(28,OUTPUT);
    break;
    case 29:
      pinModeFast(29,OUTPUT);
    break;
    case 30:
      pinModeFast(30,OUTPUT);
    break;
    case 31:
      pinModeFast(31,OUTPUT);
    break;
    case 32:
      pinModeFast(32,OUTPUT);
    break;
    case 33:
      pinModeFast(33,OUTPUT);
    break;
    case 34:
      pinModeFast(34,OUTPUT);
    break;
    case 35:
      pinModeFast(35,OUTPUT);
    break;
    case 36:
      pinModeFast(36,OUTPUT);
    break;
    case 37:
      pinModeFast(37,OUTPUT);
    break;
    case 38:
      pinModeFast(38,OUTPUT);
    break;
    case 39:
      pinModeFast(39,OUTPUT);
    break;
    case 40:
      pinModeFast(40,OUTPUT);
    break;
    case 41:
      pinModeFast(41,OUTPUT);
    break;
    case 42:
      pinModeFast(42,OUTPUT);
    break;
    case 43:
      pinModeFast(43,OUTPUT);
    break;
    case 44:
      pinModeFast(44,OUTPUT);
    break;
    case 45:
      pinModeFast(45,OUTPUT);
    break;
    case 46:
      pinModeFast(46,OUTPUT);
    break;
    case 47:
      pinModeFast(47,OUTPUT);
    break;
    case 48:
      pinModeFast(48,OUTPUT);
    break;
    case 49:
      pinModeFast(49,OUTPUT);
    break;
    case 50:
      pinModeFast(50,OUTPUT);
    break;
    case 51:
      pinModeFast(51,OUTPUT);
    break;
    case 52:
      pinModeFast(52,OUTPUT);
    break;
    case 53:
      pinModeFast(53,OUTPUT);
    break;
    case 54:
      pinModeFast(54,OUTPUT);
    break;
    case 55:
      pinModeFast(55,OUTPUT);
    break;
    case 56:
      pinModeFast(56,OUTPUT);
    break;
    case 57:
      pinModeFast(57,OUTPUT);
    break;
    case 58:
      pinModeFast(58,OUTPUT);
    break;
    case 59:
      pinModeFast(59,OUTPUT);
    break;
  }
}
void digitalWriteFastHighSwitch(int value)
{
  switch (value)
  {
    case 2:
      digitalWriteFast(2,HIGH);
    break;
    case 3:
      digitalWriteFast(3,HIGH);
    break;
    case 4:
      digitalWriteFast(4,HIGH);
    break;
    case 5:
      digitalWriteFast(5,HIGH);
    break;
    case 6:
      digitalWriteFast(6,HIGH);
    break;
    case 7:
      digitalWriteFast(7,HIGH);
    break;
    case 8:
      digitalWriteFast(8,HIGH);
    break;
    case 9:
      digitalWriteFast(9,HIGH);
    break;
    case 10:
      digitalWriteFast(10,HIGH);
    break;
    case 11:
      digitalWriteFast(11,HIGH);
    break;
    case 12:
      digitalWriteFast(12,HIGH);
    break;
    case 13:
      digitalWriteFast(13,HIGH);
    break;
    case 14:
      digitalWriteFast(14,HIGH);
    break;
    case 15:
      digitalWriteFast(15,HIGH);
    break;
    case 16:
      digitalWriteFast(16,HIGH);
    break;
    case 17:
      digitalWriteFast(17,HIGH);
    break;
    case 18:
      digitalWriteFast(18,HIGH);
    break;
    case 19:
      digitalWriteFast(19,HIGH);
    break;
    case 20:
      digitalWriteFast(20,HIGH);
    break;
    case 21:
      digitalWriteFast(21,HIGH);
    break;
    case 22:
      digitalWriteFast(22,HIGH);
    break;
    case 23:
      digitalWriteFast(23,HIGH);
    break;
    case 24:
      digitalWriteFast(24,HIGH);
    break;
    case 25:
      digitalWriteFast(25,HIGH);
    break;
    case 26:
      digitalWriteFast(26,HIGH);
    break;
    case 27:
      digitalWriteFast(27,HIGH);
    break;
    case 28:
      digitalWriteFast(28,HIGH);
    break;
    case 29:
      digitalWriteFast(29,HIGH);
    break;
    case 30:
      digitalWriteFast(30,HIGH);
    break;
    case 31:
      digitalWriteFast(31,HIGH);
    break;
    case 32:
      digitalWriteFast(32,HIGH);
    break;
    case 33:
      digitalWriteFast(33,HIGH);
    break;
    case 34:
      digitalWriteFast(34,HIGH);
    break;
    case 35:
      digitalWriteFast(35,HIGH);
    break;
    case 36:
      digitalWriteFast(36,HIGH);
    break;
    case 37:
      digitalWriteFast(37,HIGH);
    break;
    case 38:
      digitalWriteFast(38,HIGH);
    break;
    case 39:
      digitalWriteFast(39,HIGH);
    break;
    case 40:
      digitalWriteFast(40,HIGH);
    break;
    case 41:
      digitalWriteFast(41,HIGH);
    break;
    case 42:
      digitalWriteFast(42,HIGH);
    break;
    case 43:
      digitalWriteFast(43,HIGH);
    break;
    case 44:
      digitalWriteFast(44,HIGH);
    break;
    case 45:
      digitalWriteFast(45,HIGH);
    break;
    case 46:
      digitalWriteFast(46,HIGH);
    break;
    case 47:
      digitalWriteFast(47,HIGH);
    break;
    case 48:
      digitalWriteFast(48,HIGH);
    break;
    case 49:
      digitalWriteFast(49,HIGH);
    break;
    case 50:
      digitalWriteFast(50,HIGH);
    break;
    case 51:
      digitalWriteFast(51,HIGH);
    break;
    case 52:
      digitalWriteFast(52,HIGH);
    break;
    case 53:
      digitalWriteFast(53,HIGH);
    break;
    case 54:
      digitalWriteFast(54,HIGH);
    break;
    case 55:
      digitalWriteFast(55,HIGH);
    break;
    case 56:
      digitalWriteFast(56,HIGH);
    break;
    case 57:
      digitalWriteFast(57,HIGH);
    break;
    case 58:
      digitalWriteFast(58,HIGH);
    break;
    case 59:
      digitalWriteFast(59,HIGH);
    break;
  }
}
void digitalWriteFastLowSwitch(int value)
{
  switch (value)
  {
    case 2:
      digitalWriteFast(2,LOW);
    break;
    case 3:
      digitalWriteFast(3,LOW);
    break;
    case 4:
      digitalWriteFast(4,LOW);
    break;
    case 5:
      digitalWriteFast(5,LOW);
    break;
    case 6:
      digitalWriteFast(6,LOW);
    break;
    case 7:
      digitalWriteFast(7,LOW);
    break;
    case 8:
      digitalWriteFast(8,LOW);
    break;
    case 9:
      digitalWriteFast(9,LOW);
    break;
    case 10:
      digitalWriteFast(10,LOW);
    break;
    case 11:
      digitalWriteFast(11,LOW);
    break;
    case 12:
      digitalWriteFast(12,LOW);
    break;
    case 13:
      digitalWriteFast(13,LOW);
    break;
    case 14:
      digitalWriteFast(14,LOW);
    break;
    case 15:
      digitalWriteFast(15,LOW);
    break;
    case 16:
      digitalWriteFast(16,LOW);
    break;
    case 17:
      digitalWriteFast(17,LOW);
    break;
    case 18:
      digitalWriteFast(18,LOW);
    break;
    case 19:
      digitalWriteFast(19,LOW);
    break;
    case 20:
      digitalWriteFast(20,LOW);
    break;
    case 21:
      digitalWriteFast(21,LOW);
    break;
    case 22:
      digitalWriteFast(22,LOW);
    break;
    case 23:
      digitalWriteFast(23,LOW);
    break;
    case 24:
      digitalWriteFast(24,LOW);
    break;
    case 25:
      digitalWriteFast(25,LOW);
    break;
    case 26:
      digitalWriteFast(26,LOW);
    break;
    case 27:
      digitalWriteFast(27,LOW);
    break;
    case 28:
      digitalWriteFast(28,LOW);
    break;
    case 29:
      digitalWriteFast(29,LOW);
    break;
    case 30:
      digitalWriteFast(30,LOW);
    break;
    case 31:
      digitalWriteFast(31,LOW);
    break;
    case 32:
      digitalWriteFast(32,LOW);
    break;
    case 33:
      digitalWriteFast(33,LOW);
    break;
    case 34:
      digitalWriteFast(34,LOW);
    break;
    case 35:
      digitalWriteFast(35,LOW);
    break;
    case 36:
      digitalWriteFast(36,LOW);
    break;
    case 37:
      digitalWriteFast(37,LOW);
    break;
    case 38:
      digitalWriteFast(38,LOW);
    break;
    case 39:
      digitalWriteFast(39,LOW);
    break;
    case 40:
      digitalWriteFast(40,LOW);
    break;
    case 41:
      digitalWriteFast(41,LOW);
    break;
    case 42:
      digitalWriteFast(42,LOW);
    break;
    case 43:
      digitalWriteFast(43,LOW);
    break;
    case 44:
      digitalWriteFast(44,LOW);
    break;
    case 45:
      digitalWriteFast(45,LOW);
    break;
    case 46:
      digitalWriteFast(46,LOW);
    break;
    case 47:
      digitalWriteFast(47,LOW);
    break;
    case 48:
      digitalWriteFast(48,LOW);
    break;
    case 49:
      digitalWriteFast(49,LOW);
    break;
    case 50:
      digitalWriteFast(50,LOW);
    break;
    case 51:
      digitalWriteFast(51,LOW);
    break;
    case 52:
      digitalWriteFast(52,LOW);
    break;
    case 53:
      digitalWriteFast(53,LOW);
    break;
    case 54:
      digitalWriteFast(54,LOW);
    break;
    case 55:
      digitalWriteFast(55,LOW);
    break;
    case 56:
      digitalWriteFast(56,LOW);
    break;
    case 57:
      digitalWriteFast(57,LOW);
    break;
    case 58:
      digitalWriteFast(58,LOW);
    break;
    case 59:
      digitalWriteFast(59,LOW);
    break;
  }
}
