/**************************************************************************
*                                                                         *
*             Java Grande Forum Benchmark Suite - Version 2.0             *
*                                                                         *
*                            produced by                                  *
*                                                                         *
*                  Java Grande Benchmarking Project                       *
*                                                                         *
*                                at                                       *
*                                                                         *
*                Edinburgh Parallel Computing Centre                      *
*                                                                         * 
*                email: epcc-javagrande@epcc.ed.ac.uk                     *
*                                                                         *
*                                                                         *
*      This version copyright (c) The University of Edinburgh, 1999.      *
*                         All rights reserved.                            *
*                                                                         *
**************************************************************************/


using System;

namespace CSGrande
{

    public class JGFAssignBench
    {

        //public const int INITSIZE =   10000;
        //public const int MAXSIZE =    1000000000;
        public const int INITSIZE =     10000;
        public const int MAXSIZE =      100000;

        static int a1 = 1, a2 = 2, a3 = 3, a4 = 4;
        static int[] b ={ 1, 2, 3, 4 };

        int c1 = 1, c2 = 2, c3 = 3, c4 = 4;
        int[] d ={ 1, 2, 3, 4 };

        public void JGFrun()
        {

            int i, size;

            int e1 = 1, e2 = 2, e3 = 3, e4 = 4;
            int[] f ={ 1, 2, 3, 4 };


            size = INITSIZE;

            while (size < MAXSIZE)
            {
                for (i = 0; i < size; i++)
                {
                    e1 = e2;
                    e2 = e3;
                    e3 = e4;
                    e4 = e1;
                    e1 = e2;
                    e2 = e3;
                    e3 = e4;
                    e4 = e1;
                    e1 = e2;
                    e2 = e3;
                    e3 = e4;
                    e4 = e1;
                    e1 = e2;
                    e2 = e3;
                    e3 = e4;
                    e4 = e1;
                }
                // try to defeat dead code elimination 
                if (e4 == e3) Console.WriteLine(e4);
                size *= 2;
            }

            size = INITSIZE;

            while (size < MAXSIZE)
            {
                for (i = 0; i < size; i++)
                {
                    c1 = c2;
                    c2 = c3;
                    c3 = c4;
                    c4 = c1;
                    c1 = c2;
                    c2 = c3;
                    c3 = c4;
                    c4 = c1;
                    c1 = c2;
                    c2 = c3;
                    c3 = c4;
                    c4 = c1;
                    c1 = c2;
                    c2 = c3;
                    c3 = c4;
                    c4 = c1;
                }
                // try to defeat dead code elimination 
                if (c4 == c3) Console.WriteLine(c4);
                size *= 2;
            }

            size = INITSIZE;

            while (size < MAXSIZE)
            {
                for (i = 0; i < size; i++)
                {
                    a1 = a2;
                    a2 = a3;
                    a3 = a4;
                    a4 = a1;
                    a1 = a2;
                    a2 = a3;
                    a3 = a4;
                    a4 = a1;
                    a1 = a2;
                    a2 = a3;
                    a3 = a4;
                    a4 = a1;
                    a1 = a2;
                    a2 = a3;
                    a3 = a4;
                    a4 = a1;
                }
                // try to defeat dead code elimination 
                if (a3 == a4) Console.WriteLine(a3);
                size *= 2;
            }

            size = INITSIZE;

            while (size < MAXSIZE)
            {
                for (i = 0; i < size; i++)
                {
                    f[0] = f[1];
                    f[1] = f[2];
                    f[2] = f[3];
                    f[3] = f[0];
                    f[0] = f[1];
                    f[1] = f[2];
                    f[2] = f[3];
                    f[3] = f[0];
                    f[0] = f[1];
                    f[1] = f[2];
                    f[2] = f[3];
                    f[3] = f[0];
                    f[0] = f[1];
                    f[1] = f[2];
                    f[2] = f[3];
                    f[3] = f[0];
                }
                // try to defeat dead code elimination 
                if (f[3] == f[2]) Console.WriteLine(f[3]);
                size *= 2;
            }

            size = INITSIZE;

            while (size < MAXSIZE)
            {
                for (i = 0; i < size; i++)
                {
                    d[0] = d[1];
                    d[1] = d[2];
                    d[2] = d[3];
                    d[3] = d[0];
                    d[0] = d[1];
                    d[1] = d[2];
                    d[2] = d[3];
                    d[3] = d[0];
                    d[0] = d[1];
                    d[1] = d[2];
                    d[2] = d[3];
                    d[3] = d[0];
                    d[0] = d[1];
                    d[1] = d[2];
                    d[2] = d[3];
                    d[3] = d[0];
                    d[0] = d[1];
                    d[1] = d[2];
                    d[2] = d[3];
                    d[3] = d[0];
                    d[0] = d[1];
                    d[1] = d[2];
                    d[2] = d[3];
                    d[3] = d[0];
                    d[0] = d[1];
                    d[1] = d[2];
                    d[2] = d[3];
                    d[3] = d[0];
                    d[0] = d[1];
                    d[1] = d[2];
                    d[2] = d[3];
                    d[3] = d[0];
                }
                // try to defeat dead code elimination 
                if (d[3] == d[2]) Console.WriteLine(d[3]);
                size *= 2;
            }

            size = INITSIZE;

            while (size < MAXSIZE)
            {
                for (i = 0; i < size; i++)
                {
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[0];
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[0];
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[0];
                    b[0] = b[1];
                    b[1] = b[2];
                    b[2] = b[3];
                    b[3] = b[0];
                }
                // try to defeat dead code elimination 
                if (b[3] == b[2]) Console.WriteLine(b[3]);
                size *= 2;
            }

            AssignTester at = new AssignTester();

            size = INITSIZE;

            while (size < MAXSIZE)
            {
                for (i = 0; i < size; i++)
                {
                    at.c1 = at.c2;
                    at.c2 = at.c3;
                    at.c3 = at.c4;
                    at.c4 = at.c1;
                    at.c1 = at.c2;
                    at.c2 = at.c3;
                    at.c3 = at.c4;
                    at.c4 = at.c1;
                    at.c1 = at.c2;
                    at.c2 = at.c3;
                    at.c3 = at.c4;
                    at.c4 = at.c1;
                    at.c1 = at.c2;
                    at.c2 = at.c3;
                    at.c3 = at.c4;
                    at.c4 = at.c1;
                }
                // try to defeat dead code elimination 
                if (at.c3 == at.c4) Console.WriteLine(at.c3);
                size *= 2;
            }

            size = INITSIZE;

            while (size < MAXSIZE)
            {
                for (i = 0; i < size; i++)
                {
                    AssignTester.a1 = AssignTester.a2;
                    AssignTester.a2 = AssignTester.a3;
                    AssignTester.a3 = AssignTester.a4;
                    AssignTester.a4 = AssignTester.a1;
                    AssignTester.a1 = AssignTester.a2;
                    AssignTester.a2 = AssignTester.a3;
                    AssignTester.a3 = AssignTester.a4;
                    AssignTester.a4 = AssignTester.a1;
                    AssignTester.a1 = AssignTester.a2;
                    AssignTester.a2 = AssignTester.a3;
                    AssignTester.a3 = AssignTester.a4;
                    AssignTester.a4 = AssignTester.a1;
                    AssignTester.a1 = AssignTester.a2;
                    AssignTester.a2 = AssignTester.a3;
                    AssignTester.a3 = AssignTester.a4;
                    AssignTester.a4 = AssignTester.a1;
                }
                // try to defeat dead code elimination 
                if (AssignTester.a3 == AssignTester.a4) Console.WriteLine(AssignTester.a3);
                size *= 2;
            }

            size = INITSIZE;

            while (size < MAXSIZE)
            {
                for (i = 0; i < size; i++)
                {
                    at.d[0] = at.d[1];
                    at.d[1] = at.d[2];
                    at.d[2] = at.d[3];
                    at.d[3] = at.d[0];
                    at.d[0] = at.d[1];
                    at.d[1] = at.d[2];
                    at.d[2] = at.d[3];
                    at.d[3] = at.d[0];
                    at.d[0] = at.d[1];
                    at.d[1] = at.d[2];
                    at.d[2] = at.d[3];
                    at.d[3] = at.d[0];
                    at.d[0] = at.d[1];
                    at.d[1] = at.d[2];
                    at.d[2] = at.d[3];
                    at.d[3] = at.d[0];
                }
                // try to defeat dead code elimination 
                if (at.d[3] == at.d[2]) Console.WriteLine(at.d[3]);
                size *= 2;
            }

            size = INITSIZE;

            while (size < MAXSIZE)
            {
                for (i = 0; i < size; i++)
                {
                    AssignTester.b[0] = AssignTester.b[1];
                    AssignTester.b[1] = AssignTester.b[2];
                    AssignTester.b[2] = AssignTester.b[3];
                    AssignTester.b[3] = AssignTester.b[0];
                    AssignTester.b[0] = AssignTester.b[1];
                    AssignTester.b[1] = AssignTester.b[2];
                    AssignTester.b[2] = AssignTester.b[3];
                    AssignTester.b[3] = AssignTester.b[0];
                    AssignTester.b[0] = AssignTester.b[1];
                    AssignTester.b[1] = AssignTester.b[2];
                    AssignTester.b[2] = AssignTester.b[3];
                    AssignTester.b[3] = AssignTester.b[0];
                    AssignTester.b[0] = AssignTester.b[1];
                    AssignTester.b[1] = AssignTester.b[2];
                    AssignTester.b[2] = AssignTester.b[3];
                    AssignTester.b[3] = AssignTester.b[0];
                }
                // try to defeat dead code elimination 
                if (AssignTester.b[3] == AssignTester.b[2]) Console.WriteLine(AssignTester.b[3]);
                size *= 2;
            }

        }
        public static void Main()
        {

            JGFAssignBench asb = new JGFAssignBench();
            asb.JGFrun();

        }

    }

    public class AssignTester
    {

        public static int a1 = 1, a2 = 2, a3 = 3, a4 = 4;
        public static int[] b ={ 1, 2, 3, 4 };
        public int c1 = 1, c2 = 2, c3 = 3, c4 = 4;
        public int[] d ={ 1, 2, 3, 4 };

    }
}
