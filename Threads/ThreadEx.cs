using System;
using System.Threading;

class ThreadDemo{
		static void Thread1(){
		for(int i=0;i<5;i++){
		Console.WriteLine("Thread1 is strted");
		Console.WriteLine("Thread1 is strted at the position",+i);
		}
		Console.WriteLine("Thread1 is exit");
		}
		
		static void Thread2(){
		for(int i=0;i<5;i++){
		if(i==5){
		Console.WriteLine("thread 2 is sleeping fr sec");
		Thread.Sleep(14000);
		}
		Console>WriteLine("thread2 woke up after 5 sec......thread2 started");

		Console.WriteLine("Thread2 is strted at the position",+i);
		}

		Console.WriteLine("Thread2 is exit");
		}
		
		static void Thread2(){
		for(int i=0;i<5;i++){
		Console.WriteLine("Thread3 is strted");
		Console.WriteLine("Thread3 is strted at the position",+i);
			}
			Console.WriteLine("Thread3 is exit");
				}
		
		

		



		static void Main(string[] args)
		{
		//Instatiating the methods created
		Thread1();
		Thread2();
		Thread3();
		Console.WriteLine("mainn thread executesa all");
		
		Console.ReadLine();

}
}