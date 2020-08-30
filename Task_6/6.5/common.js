﻿document.addEventListener('DOMContentLoaded', Ready);

class Note {
    constructor(header, text) {
        this.header = header;
        this.text = text;
    }
}

let storage = new Service();

function Ready() {
    let find_text = document.getElementById("find_text");
    let search_but = document.getElementById("search_but");
    let add_but = document.getElementById("add");
    let but_close = document.getElementById("but_close");
    let but_save = document.getElementById("but_save");
    let win_header_text = document.getElementById("win_header_text");
    let win_text_text = document.getElementById("win_text_text");

    find_text.addEventListener("keyup", FindInput);
    search_but.addEventListener("click", FindInput);
    add_but.addEventListener("click", AddNote);
    but_close.addEventListener("click", WindowClose);
    but_save.addEventListener("click", SaveNote);
    win_header_text.addEventListener("keyup", ClearWarning);
    win_text_text.addEventListener("keyup", ClearWarning);

    GetNotesFromStorage();
}

function FindInput() {
    let text = document.getElementById("find_text").value.toLowerCase().trim();
    let notes = document.getElementsByClassName("note");

    if (text == "") {
        for (let i = 0; i < notes.length; i++) {
            ElemVisibilityTrigger(notes[i], true);
        }
    }
    else {
        for (let i = 0; i < notes.length; i++) {
            if (notes[i].querySelector(".note_header").innerHTML.toLowerCase().indexOf(text) != -1 || 
                notes[i].querySelector(".note_text").innerHTML.toLowerCase().indexOf(text) != -1)
                ElemVisibilityTrigger(notes[i], true);
            else
                ElemVisibilityTrigger(notes[i], false);
        }
    }
}

function ElemVisibilityTrigger(elem, visibility) {
    if (visibility) {
        elem.classList.remove("disabled");
        elem.classList.add("visible");
    }
    else {
        elem.classList.remove("visible");
        elem.classList.add("disabled");
    }
}

function AddNote() {
    WindowOpen();
}

function EditNote(node) {
    let header = node.querySelector(".note_header").innerHTML;
    let text = node.querySelector(".note_text").innerHTML;
    let id = node.firstChild.value;

    WindowOpen(header, text, id);
}

function DeleteNote(node) {
    event.stopPropagation();
    result = confirm("Думаете стоит удалить?");
    if (!result)
        return;
    let id = node.firstChild.value;
    storage.deleteById(id);
    node.remove();
}

function NotesClearHTML() {
    let notes_wrapper = document.getElementById("notes_wrapper");
    notes_wrapper.innerHTML = "";
}

function ClearWarning() {
    let win_header_text = document.getElementById("win_header_text");
    let win_text_text = document.getElementById("win_text_text");

    win_header_text.classList.remove("warning");
    win_text_text.classList.remove("warning");
}

function PrintNote(note) {
    let notes_wrapper = document.getElementById("notes_wrapper");

    let note_div = document.createElement("div");
    note_div.classList.add("note");
    note_div.classList.add("visible");

    let note_id = document.createElement("input");
    note_id.classList.add("note_id");
    note_id.setAttribute("type", "hidden");
    note_id.setAttribute("value", note.id);

    let note_header = document.createElement("div");
    note_header.classList.add("note_header");
    note_header.innerHTML = note.header;

    let note_text = document.createElement("div");
    note_text.classList.add("note_text");
    note_text.innerHTML = note.text;

    let delete_but = document.createElement("div");
    delete_but.classList.add("delete_note");
    delete_but.innerHTML = '<img src="delete.png" alt="Удалить" />';
    delete_but.firstChild.addEventListener("click", () => DeleteNote(note_div), true);

    note_div.addEventListener("click", () => EditNote(note_div), false);

    note_div.append(note_id);
    note_div.append(note_header);
    note_div.append(note_text);
    note_div.append(delete_but);

    notes_wrapper.prepend(note_div);
}

function WindowOpen(note_header = "", note_text = "", note_id = "") {
    let win_header = document.getElementById("win_header_text");
    win_header.value = note_header;

    let win_text = document.getElementById("win_text_text");
    win_text.value = note_text;

    let win_id = document.getElementById("win_id");
    win_id.value = note_id;

    let window = document.getElementById("blocker");

    ElemVisibilityTrigger(window, true);
}

function WindowClose() {
    let window = document.getElementById("blocker");

    ElemVisibilityTrigger(window, false);
}

function GetNoteDOMFromId(id) {
    let notes_id = document.getElementsByClassName("note_id");

    for (let i = 0; i < notes_id.length; i++) {
        if (notes_id[i].value == id)
            return notes_id[i].parentNode;
    }

    return null;
}

function SaveNote() {
    let header_node = document.getElementById("win_header_text");
    let text_node = document.getElementById("win_text_text");
    let header = header_node.value;
    let text = text_node.value;
    let id = document.getElementById("win_id").value;

    if (header == "" && text == "") {
        header_node.classList.add("warning");
        text_node.classList.add("warning");
        return;
    }

    let note = new Note(header, text);

    if (id == "")
        storage.add(note);
    else {
        GetNoteDOMFromId(id).remove();
        storage.updateById(id, note);
    }
    WindowClose();
    PrintNote(note);
}