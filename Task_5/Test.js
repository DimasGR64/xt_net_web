﻿class Service{
    constructor(){
        this.collection = [];
        this._id = 0;
    } 

    add(obj){
        if(obj == undefined){
            console.log('Попытка передать пустой объект');
        }
        else{
            this.collection.push({id: this.getNewId(),'obj': obj});
        }
    }

    getById(id){
        for(let obj of this.collection){
            if(obj == undefined){
                continue;
            }
            if(obj.id === id){
                return obj;
            }
        }
        return null;
    }

    getAll(){
        return this.collection;
    }

    deleteById(id){
        if(this.getById(id) == null){
            console.log('Попытка удалить несуществующий объект');
        }
        else{
            delete this.collection[this.collection.indexOf((this.getById(id)))];
        }
    }

    updateById(id, obj){
        if(this.getById(id) == null){
            return console.log('Попытка обратиться к несуществующему объекту');
        }
        if(obj == undefined){
            return console.log('Попытка обмена на пустой объект');
        }
        let temp = this.getById(id).obj;
        temp = Object.assign(temp, obj);

        this.replaceById(id, temp);
    }

    replaceById(id, obj){
        if(this.getById(id) == null){
            return console.log('Попытка обратиться к несуществующему объекту');
        }
        if(obj == undefined){
            return console.log('Попытка обмена на пустой объект');
        }
        this.collection[this.collection.indexOf((this.getById(id)))] = {'id': id, 'obj': obj};
    }

    getNewId(){return this._id++;}
}