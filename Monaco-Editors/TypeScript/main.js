window.editor = monaco.editor.create(document.getElementById('container'), {
    value: [
        /*
        'function x() {',
        '\tconsole.log("Hello world!");',
        '}'
        */
        "SELECT * FROM T_Benutzer ",
        "WHERE BE_User = 'administrator' "
    ].join('\n'),
    // https://github.com/Microsoft/monaco-languages
    // https://github.com/Microsoft/monaco-editor
    // https://microsoft.github.io/monaco-editor/playground.html
    //language: 'javascript'
    language: 'sql'
    //language: 'markdown'
});
function getMonacoText() {
    alert(window.editor.getValue());
}
function setMonacoText() {
    window.editor.setValue('SELECT * FROM T_Benutzer');
}
function getMonacoSelection() {
    alert(window.editor.getModel().getValueInRange(window.editor.getSelection()));
}
//# sourceMappingURL=main.js.map