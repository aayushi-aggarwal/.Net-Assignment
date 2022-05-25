 
//  Fetch data using single id 

 function getSingleId(){
     var id=document.getElementById("input").value;
     console.log(id);
     var url="http://localhost:60592/Player/"+id;
    fetch(url)
    .then(response => response.text())
    .then(result => showRecord(result))
    .catch(error => console.log('error', error));}
function showRecord(data) {
document.getElementById('div1').innerHTML = data;
}


// fetch all records

const url='http://localhost:60592/Player';
function myFunction2(){
    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
      };

      fetch("http://localhost:60592/Player", requestOptions)
        .then(response => response.text())
        .then(result => showData(result))
        .catch(error => console.log('error', error));}
function showData(data) {
    document.getElementById('div1').innerHTML = data;
}


// insert data
function insertData(){   

    let playerId = document.getElementById("player_id");

    let playerName = document.getElementById("player_name");

    let jerseyNo = document.getElementById("jersey_no");

    let age = document.getElementById("age");

    let country = document.getElementById("country");

    let dob = document.getElementById("dob");

    let gender = document.getElementById("gender");

    let sport = document.getElementById("sport");   

    // Creating a XHR object

    let xhr = new XMLHttpRequest();

    let url = "http://localhost:60592/Player";

    // open a connection

    xhr.open("POST", url, true);


    // Set the request header i.e. which type of content you are sending

    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.setRequestHeader("Access-Control-Allow-Origin","*");

    // Create a state change callback

    xhr.onreadystatechange = function () {

        if (xhr.readyState === 4 && xhr.status === 200) {

            // Print received data from server

            result.innerHTML = this.responseText;

        }

    };

    // Converting JSON data to string

    var data = JSON.stringify({  "playerId": playerId.value , "playerName":playerName.value, "jerseyNo":jerseyNo.value ,"age":age.value,"country":country.value,"dob":dob.value,"gender":gender.value,"sport":sport.value});

    // Sending data with the request

    xhr.send(data);

}

// fetching using like operation
function myFunction4() {
     var id=document.getElementById("like12").value;
     var url="http://localhost:60592/Player/Player/"+id;
     fetch(url)
     .then((res) => res.text())
     .then(ans => showData(ans))
    }
    function showData(data){
        document.getElementById('div1').innerHTML=data;
    }

