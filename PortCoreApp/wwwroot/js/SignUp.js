

function validateForm() {
    let firstName = document.getElementById("Name").value;
    let lastName = document.getElementById("Surname").value;
    let userName = document.getElementById("UserName").value;
    let email = document.getElementById("Email").value;
    let password = document.getElementById("Password").value;
    let confirmPassword = document.getElementById("ConfirmPassword").value;

    if (firstName === "" || lastName === "" || userName === "" || email === "" || password === "" || confirmPassword === "") {
        alert("All fields are required");
        return false;
    }

    if (password !== confirmPassword) {
        alert("Passwords do not match");
        return false;
    }

    if (!validateEmail(email)) {
        alert("Invalid email address");
        return false;
    }

    if (!validatePassword(password)) {
        alert("Invalid password");
        return false;
    }

    return true;
}

function isValidEmail(email) {
    let emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
    return emailPattern.test(email);
}
function isStrongPassword(password) {
    let passwordPattern = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;
    return passwordPattern.test(password);
}