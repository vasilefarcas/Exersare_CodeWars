import java.util.ArrayList;
public class Main {
    public static void main(String[] args) {
        System.out.println(EvenOrOdd(12));
        int a=11;
        int b=12;
        System.out.println(GetSum(a,b)==GetSum(b,a));
    }
    public int countSheeps(Boolean[] arrayOfSheeps) {
        int count=0;
        for(boolean item : arrayOfSheeps)
            if(item)
                count++;
        return count;
    }
    public static String EvenOrOdd(int number)
    {
        if(number%2==0)
            return "Even";
        return "Odd";
    }
    public static int GetSum(int a, int b)
    {
        if (a>b)
        {
            int aux;
            aux=a;
            a=b;
            b=aux;
        }
        int sum=0;
        for(int i=a;i<=b;i++)
            sum+=i;
        return sum;
    }
    public static void swap(int a, int b)
    {
        int aux;
        aux=a;
        a=b;
        b=aux;
    }
    public static double basicOp(char operation, double var1, double var2)
    {
        switch(operation){
        case '+':
            return var1+var2;
            case '-':
                return var1-var2;
            case '*':
                return var1*var2;
            case '/':
                return var1/var2;
        }
        return -1;
    }
}
