import java.util.Scanner;
class Celsius_To_Fahrenheit
{
    static class Celsius
    {
        public int getdata()
        {
            Scanner sc = new Scanner(System.in);
            System.out.println("Enter Celsius Value : ");
            int c = sc.nextInt();
            return c;
        }
    }
    static class Fahrenheit extends Celsius
    {
        public void putdata(int c)
        {
            double f = (c * 9/5)+32;
            System.out.println("The Value Of Celsius To Fahrenheit Is : "+f);
        }
    }

    public static void main(String args[])
    {
        Fahrenheit op = new Fahrenheit();
        int f = op.getdata();
        op.putdata(f);
    }
}
