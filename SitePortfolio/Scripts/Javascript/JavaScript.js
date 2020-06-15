function execution() {
    var texto = document.getElementById('texto').value;
    var list = document.getElementById('completar');
    var adicionar = true;

    var opcoes = document.createElement('option');

    for (i = 0, i < list.opcoes.length; i++) {
        if (texto == list.opcoes[i]) {
            adicionar = false;
        }
    }

    if (adicionar == true) {
        opcoes.value == texto;
        list.appendChild(opcoes);
    }
}