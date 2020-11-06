

//function display() {
//    console.log("Hello TypeScript!");
//}

//display(); //Output: Hello TypeScript 



//function identity(arg) {
//    return arg;
//}
//var output1 = identity("myString");
//var output2 = identity(100);
//console.log(output1);
//console.log(output2);  

//public
//class Employe {
//    public empid: number;
//    public empname: string
//        ;
//}
//let emp = new Employe();
//emp.empid=1
//emp.empname = "soumya";
//console.log(emp.empid + "" + emp.empname);


////private
//class student {
//    public studentname: string;
//    private studentid: number;


//    constructor(name: string, id: number) {
//        this.studentname = name;
//        this.studentid = id;
//    }
//    public display() {

//        return (`My unique code: ${this.studentname}, my name: ${this.studentid}.`);
//    }
//}


//       let  Student: student = new student("sou", 1);
//console.log(Student.display());


////Modules
//module Sum {
//    export function add(a, b) {
//        console.log("Sum: " + (a + b));
//    }
//}  



////Generics
//function sou<T>(arg: T): T {
//    return arg;
//}
//let output1 = sou<string>("Praveen");
//let output2 = sou<number>(100);
//console.log(output1);
//console.log(output2); 


////second ex
//function getItems(items: any[]): any[] {
//    return new Array().concat(items);
//}
//let myNumArr = getItems([10, 20, 30]);
//let myStrArr = getItems(["Hello", "JavaTpoint"]);
//myNumArr.push(40); // Correct  
//myNumArr.push("Hello TypeScript"); // Correct  
//myStrArr.push("Hello SSSIT"); // Correct  
//myStrArr.push(40); // Correct  
//console.log(myNumArr); // [10, 20, 30, 40, "Hello TypeScript"]  
//console.log(myStrArr); // ["Hello", "JavaTpoint", "Hello SSSIT", 40] 



////third example

//class StudentInfo<T, U>
//{
//    private Id: T;
//    private Name: U;
//    sou(id: T, name: U): void {
//        this.Id = id;
//        this.Name = name;
//    }
//    display(): void {
//        console.log(`Id = ${this.Id}, Name = ${this.Name}`);
//    }
//}
//let st = new StudentInfo<number, string>();
//st.sou(101, "Virat");
//st.display();
//let std = new StudentInfo<string, string>();
//std.sou("201", "Rohit");
//std.display();  

let arr: string[] = new Array("soumya", "222", "sss", "ppp");
for (var i = 0; i < arr.length; i++) {
    console.log(arr[i]);
}



    

