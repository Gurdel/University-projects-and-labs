package com.company;

import java.math.BigInteger;
import java.util.Random;
import java.util.Scanner;

public class Main {
    private final static BigInteger ZERO = new BigInteger("0");
    private final static BigInteger ONE  = new BigInteger("1");
    private final static BigInteger TWO  = new BigInteger("2");
    private final static BigInteger THREE  = new BigInteger("3");
    private final static BigInteger FOUR  = new BigInteger("4");
    private final static BigInteger FIVE  = new BigInteger("5");
    private final static BigInteger EIGHT  = new BigInteger("8");

    /** Function to calculate jacobi (a/b) **/
    public static BigInteger Jacobi(BigInteger a, BigInteger b)
    {
        if (b.compareTo(ZERO) <= 0 || b.mod(TWO).equals(ZERO))
            return ZERO;
        BigInteger j = ONE;
        if (a.compareTo(ZERO) < 0)
        {
            a = ZERO.subtract(a);
            if (b.mod(FOUR).equals(THREE))
                j = ZERO.subtract(j);
        }
        while (!a.equals(ZERO))
        {
            while (a.mod(TWO).equals(ZERO))
            {
                a = a.divide(TWO);
                if (b.mod(EIGHT).equals(THREE) || b.mod(EIGHT).equals(FIVE))
                    j = ZERO.subtract(j);
            }

            BigInteger temp = a;
            a = b;
            b = temp;

            if (a.mod(FOUR).equals(THREE) && b.mod(FOUR).equals(THREE))
                j = ZERO.subtract(j);
            a = a.mod(b);
        }
        if (b.equals(ONE))
            return j;
        return ZERO;
    }
    /** Function to check if prime or not **/
    public static BigInteger getRandomBigInteger() {
        Random rand = new Random();
        BigInteger result = new BigInteger(100, rand);
        return result;
    }

    public static boolean isPrime(BigInteger n, int iteration)
    {
        /** base case **/
        if (n.equals(ZERO) || n.equals(ONE))
            return false;
        /** base case - 2 is prime **/
        if (n.equals(TWO))
            return true;
        /** an even number other than 2 is composite **/
        if (n.mod(TWO).equals(ZERO))
            return false;

        Random rand = new Random();
        for (int i = 0; i < iteration; i++)
        {
            BigInteger r = getRandomBigInteger();
            BigInteger a = r.mod(n.subtract(ONE)).add(ONE);
            BigInteger jacobian = (n.add(Jacobi(a, n))).mod(n);
            BigInteger mod = a.modPow(n.subtract(ONE).divide(TWO), n);
            if(jacobian.equals(ZERO) || !mod.equals(jacobian))
                return false;
        }
        return true;
    }

    public static void main(String[] args) {
        BigInteger n;
        int it;
        System.out.print("Enter any number to check: ");
        Scanner sc = new Scanner(System.in);
        n = sc.nextBigInteger();
        System.out.println("N is: " + n);
        System.out.print("Enter number of iterations: ");
        sc = new Scanner(System.in);
        it = sc.nextInt();
        long startTime = System.nanoTime();
        System.out.println("Iterations: " + it);
        if (isPrime(n, it))
        {
            System.out.println("prime");
        }
        else
        {	System.out.println("non-prime");}
        double estimatedTime = (double) (System.nanoTime() - startTime) / 1000000000;
        System.out.println("\nTime total: " + estimatedTime);
    }
}
