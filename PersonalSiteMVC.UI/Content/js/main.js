//Copyright year
let copyrightYear = document.getElementById('copyrightYear');
copyrightYear.textContent = new Date().getFullYear();

function sendContactUs() {
    let name = document.getElementById('tbName').value;

    let email = document.getElementById('tbEmail').value;

    let subject = document.getElementById("tbSubject").value;

    let message = document.getElementById('tbMessage').value;

    let messageBack = document.getElementById('messageBack');

    if (!name) {
        let tbName = document.getElementById('tbName');
        messageBack.style.color = 'darkred';
        messageBack.textContent = "ERROR: Name Must Be Filled In";
    }
    else
        if (!validateEmail(email)) {
            messageBack.style.color = 'darkred';
            messageBack.textContent = "ERROR: Email Must Be Filled In With Correct Format";
        }
        else
            if (!subject) {
                messageBack.style.color = 'darkred';
                messageBack.textContent = "ERROR: Subject Must Be Filled In";
            }
            else
                if (!message) {
                    messageBack.style.color = 'darkred';
                    messageBack.textContent = "ERROR: Message Must Be Filled In";
                }
                else {
                    messageBack.style.color = 'darkgreen';
                    messageBack.textContent = "Thank you for contacting me, I will respond as soon as possible";
                }
}

function validateEmail(email) {
    var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
}
