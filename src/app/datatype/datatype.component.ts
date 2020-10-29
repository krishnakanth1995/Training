import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-datatype',
  templateUrl: './datatype.component.html',
  styleUrls: ['./datatype.component.css']
})
export class DatatypeComponent implements OnInit {

  name:string="krishna";
  age:number;
  hobbies:string[];
  marks:Array<number>;
  Istrue:boolean;
  tupleval:[string,number,boolean];
  dynamicvalue:any;
  picture="Images/finding-sunshine.jpg"


  constructor() { 

    this.age=25;
    this.hobbies=["playing","browsing"];
    this.marks=[89,90,100];
    this.Istrue=false;
    this.tupleval=["krishna",25,true];
    this.dynamicvalue="Hello!!"
    this.dynamicvalue=true;



  }

  ngOnInit() {
  }

}
