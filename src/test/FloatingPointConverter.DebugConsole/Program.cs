using FloatingPointConverter;

string value1 = "1.2342342klnadn";
string value2 = "1,2342342lsafkn";

double dresult1 = SecureConverter.ToDouble(value1);
double dresult2 = SecureConverter.ToDouble(value2);

float fresult1 = SecureConverter.ToFloat(value1);
float fresult2 = SecureConverter.ToFloat(value2);

decimal mresult1 = SecureConverter.ToDecimal(value1);
decimal mresult2 = SecureConverter.ToDecimal(value2);

Console.ReadLine();