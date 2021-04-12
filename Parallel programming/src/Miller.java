import java.math.BigInteger;
import java.security.SecureRandom;
import java.util.*;
import java.io.*;
import parcs.*;

public class Miller implements AM {

public static void main(String[] args) {
        task curtask = new task();
        curtask.addJarFile("Miller.jar");
        (new Miller()).run(new AMInfo(curtask, (channel)null));
        curtask.end();
    }

    public void run(AMInfo info) {
        int my_result = 0;
	BigInteger n;
	int it;
			//Scanner sc = new Scanner(new File(info.curtask.findFile("Solovey.data")));
			System.out.print("Enter any number to check: ");
			Scanner sc = new Scanner(System.in);
			n = sc.nextBigInteger();
			System.out.println("N is: " + n);
			System.out.print("Enter number of iterations: ");
			sc = new Scanner(System.in);
			it = sc.nextInt();
	long startTime = System.nanoTime();
	System.out.println("Iterations: " + it);

        /*

	point p = info.createPoint();
        channel c = p.createChannel();
        p.execute("Algo");
        c.write(n);
        c.write(it);

		System.out.println("Waiting for result...");
		my_result = c.readInt();
         */

		point p1 = info.createPoint();
		channel c1 = p1.createChannel();

		p1.execute("Algo");
		c1.write(n);
		c1.write(it/2);
		point p2 = info.createPoint();
		channel c2 = p2.createChannel();
		p2.execute("Algo");
		c2.write(n);
		c2.write(it/2);

		int r1=c1.readInt();
		int r2=c2.readInt();
		my_result=(r1+r2) / 2;
	System.out.println("Result found.");
	if (my_result == 1)
	{
	System.out.println("prime");
	}
	else
	{	System.out.println("non-prime");}
	double estimatedTime = (double) (System.nanoTime() - startTime) / 1000000000;
	System.out.println("\nTime total: " + estimatedTime);
	try {
          PrintWriter out = new PrintWriter(new FileWriter(info.curtask.addPath("Solovey.res")));
          out.println(my_result);
          out.close();
      } catch (IOException e) {e.printStackTrace(); return;}
    }
}
