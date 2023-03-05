body {
    background-color: black;
}
.box {
    width: 100%;
    height: 600px;
    display: grid;
    grid-template-columns: 1fr 2fr;
    grid-template-rows: 1fr 2fr 2fr;

}
.title {
    color: aliceblue;
    grid-column: 2/3;
    grid-row: 1/2;
}
.handleDate {
   grid-column: 2/3;
    width:auto;
    height: 522px;
    border-radius:10px ;
    display:grid;
    grid-template-columns: 1fr 2fr 1fr;
    grid-template-rows:100px 100px 100px 100px;
    border: 1px solid darkgray;

}
.V1 {
    width: 167px;
    height: 23px;
    background-color:aliceblue;
    border: 1px solid black;
    border-radius: 10px;
    grid-column: 2/3;
    grid-row: 1/2;
    margin-top: 50px;
}
.V2 {
    width: 120px;
    height: 19px;
   
    border: 1px solid black;
    grid-column: 2/3;
    grid-row: 2/3;
    margin-top: 25px;
}
.V3 {
    width: 160px;
    height: 20px;;
    border: 1px solid black;
    grid-column: 2/3;
    grid-row: 3/4;
    
}
.IV2 {
    width: 160px;
    height: 20px;
    font-weight: bold;
    border-radius: 10px;
    grid-column: 2/3;
    grid-row: 2/3;

}
.IV3 {
    width: 160px;
    height: 20px;
    border-radius: 10px;
    font-weight: bold;
    grid-column: 2/3;
    grid-row: 3/4;

}
.check {
   grid-column: 2/3;
   margin-left: 40px; 
}
.check-result {

}
.V1-text {
    position:absolute;
    top: 125px;
    margin-left: 30px;
    font-weight:  bold;
}
.note {
    color:rgb(207, 75, 27) ;
    grid-column: 2/3;
}
/* music*/

.music {
    border: 1px solid darkgray;
    min-width: 300px;
    overflow: auto;
    grid-column: 1/2;
    grid-row: 2/4;
    border-radius: 10px;
   
    
}
.music::-webkit-scrollbar {
    width:5px;
    height: 5px;
}
.music::-webkit-scrollbar-thumb {
    background-image: linear-gradient(to bottom,rgb(23, 61, 200),rgb(26, 164, 198));
    border-radius: 200px;
}
.music::-webkit-scrollbar-track {
    background-color: #beb7b7;
    border-radius: 200px;
}


.modeSwitch--text {
    color:antiquewhite;
    font-weight: bold;
    transform: translateY(-40%);
    cursor: pointer;
    text-decoration: none;
   
  }
  .modeSwitch--text:hover{
     color: rgb(15, 116, 205);
    
  } 
  
   .modeSwitch{
    background-color: rgb(6, 6, 6);
    width: 220px;
    height: 30px;
    border-radius: 5px;
    /* margin-top: 255px; */
    grid-column: 2/3;
    grid-row: 5/6;
    margin-left: 10px;
  } 
  .wrongResult{
    width: 200px;
    height: 150px;
    background-color: rgb(11, 10, 10);
    border-radius: 10px;
    grid-column: 3/4;
    grid-row: 3/4;;
    margin-right: 15px;
    transform: translateY(-60%);
}
.wrongResult--V2{
    font-weight: bold;
    color: aliceblue;
    display: none;
}
.wrongResult--V3{
    font-weight: bold;
    color: aliceblue;
    margin-top: 55px;
    display: none;
}
.resultDisplay{
    width: 120px;
    height: 30px;
    background-color: rgb(14, 14, 13);
    border-radius: 10px;
    grid-column: 3/4;
    grid-row: 4/5;;
    margin-right: 15px;
    transform: translateY(0%);
    font-weight: bold;
    color: rgb(70, 162, 242);
    cursor: pointer;
}
.resultDisplay:hover{
    color: rgb(23, 154, 11);
}
.resultHide{
    width: 70px;
    height: 30px;
    background-color: rgb(7, 7, 6);
    border-radius: 10px;
    grid-column: 3/4;
    grid-row: 4/5;;
    margin-right: 15px;
    transform: translateX(150%);
    font-weight: bold;
    color: rgb(209, 72, 45);
    cursor: pointer;
}
.resultHide:hover{
    color: rgb(235, 49, 12);
}