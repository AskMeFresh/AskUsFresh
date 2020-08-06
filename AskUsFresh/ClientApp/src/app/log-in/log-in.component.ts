import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';


@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {
  title = 'Please Enter Your Email and Password';
  angForm: FormGroup;
  constructor(private fb: FormBuilder) {
    this.createForm();
  }
  createForm() {
    this.angForm = this.fb.group({
      Email: ['', [Validators.required,Validators.email] ],
      Password: ['', Validators.required]
    });
  }
  ngOnInit() {
  }

}
