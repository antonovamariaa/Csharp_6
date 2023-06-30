double CountX (double b1, double k1, double b2, double k2) {
    double x = (b2-b1)/(k1-k2);
    return x;}

double CountY (double k1, double x, double b1){
    double y = (k1*x)+b1;
    return y;}

double B1(string text) {
    System.Console.Write(text);
    return Convert.ToDouble(System.Console.ReadLine());}

double K1(string text) {
    System.Console.Write(text);
    return Convert.ToDouble(System.Console.ReadLine());}

double B2(string text) {
    System.Console.Write(text);
    return Convert.ToDouble(System.Console.ReadLine());}

double K2(string text) {
    System.Console.Write(text);
    return Convert.ToDouble(System.Console.ReadLine());}


double b1 = B1("input b1: ");
double k1 = K1("input k1: ");
double b2 = B2("input b2: ");
double k2 = K2("input k2: ");
double x = Math.Round(CountX(b1,k1,b2,k2), 3);
double y = Math.Round(CountY(k1, x, b1), 3);


System.Console.WriteLine($"({x}; {y})");

