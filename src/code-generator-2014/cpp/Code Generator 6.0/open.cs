using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGenCPP
{
    class open
    {
        public static int nv;
        public static int q;
        public static int a;
        public static string nameclass;
        public static string namevar;
        public static string namefunt;
        public static string messenger;
        public static int clazz;
        public static string text;
        public static string tittle;
        public static string dir;
        public static string dire;
        public static string var;
        public static bool ok;
        public static int size;
        public static bool lib;
        public static bool main;
        public static bool close;
        public static bool namezpace;
        public static int help;

        public static void window(string title, string text, bool ok)
        {
            open.tittle=title;
            open.text = text;
            open.ok = ok;
            error form = new error();
            form.Show();
        }

        public static void variable(int clasz, int size)
        {
            open.size=size;
            open.nv = clasz;
            variable form = new variable();
            form.Show();
        }

        public static void prefuntion()
        {
            prefuntions form = new prefuntions();
            form.Show();
        }

        public static void delayt()
        {
            delay form = new delay();
            form.Show();
        }

        public static void color()
        {
            colors form = new colors();
            form.Show();
        }

        public static void printf(int clasz)
        {
            open.nv = clasz;
            print form = new print();
            form.Show();
        }

        public static void coment()
        {
            comentary form = new comentary();
            form.Show();
        }

        public static void boty()
        {
            body form = new body();
            form.Show();
        }

        public static void estc()
        {
            est form = new est();
            form.Show();
        }

        public static void constant(string a)     
        {
            open.messenger = a;
            Form2 form = new Form2();
            form.Show();
        }

        public static void ifw(int b)
        {
            open.a = b;
            if_w form = new if_w();
            form.Show();
        }

        public static void switchw(int b)
        {
            open.a = b;
            switch_w form = new switch_w();
            form.Show();
        }

        public static void do_whilew(int b)
        {
            open.a = b;
            do_while_w form = new do_while_w();
            form.Show();
        }

        public static void whilew(int b)
        {
            open.a = b;
            while_w form = new while_w();
            form.Show();
        }

        public static void forw(int b)
        {
            open.a = b;
            for_w form = new for_w();
            form.Show();
        }

        public static void comand()
        { }
    }
}
