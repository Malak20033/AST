function submitCode() {
    let code = document.getElementById("input").value;
    fetch('/parse', {
        method: 'POST',
        body: JSON.stringify(code),
        headers: { 'Content-Type': 'application/json' }
    }).then(res => res.json())
      .then(data => {
          document.getElementById("ast-output").innerText = JSON.stringify(data, null, 2);
      });
}
