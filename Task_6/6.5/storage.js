﻿class Service {
    constructor() {
        this.arr = [];
    }
    add(newObj = null) {
        if (newObj === null)
            return false;
        if (this.arr.includes(newObj))
            return false;
        newObj.id = ''.replace(/[xy]/g, (c, r) => ('x' == c ? (r = Math.random() * 16 | 0) : (r & 0x3 | 0x8)).toString(16));
        this.arr.push(newObj);
        return true;
    }
    deleteById(id = '') {
        for (let i = 0; i < this.arr.length; i++) {
            if (this.arr[i].id == id) {
                let deletedObj = JSON.parse(JSON.stringify(this.arr[i]));
                this.arr.splice(i, 1);
                return deletedObj;
            }
        }
        return null;
    }
}