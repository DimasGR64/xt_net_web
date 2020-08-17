class Service 
{
    constructor()
    {
        collection = [];
        id = 12345;
    }
    add(obj)
    {
        if(obj == undefined)
        {
            console.log('объект не существует')
        }
        else
        {
            collection.push(obj)
        }
    }
    getById(id)
    {
        for(let obj of collection)
        {
            if(obj.id == id)
            {
                return obj;
            }
        }
        return null;
    }
    getAll()
    {
        return collection;
    }
    deleteById(id, obj)
    {
        if(getById(id) == null)
        {
            console.log('объект не найден');
        }
        else
        {
            delete collection[collection.indexOf(getById(id))];
        }
        return getById(id);
    }
    ubdateById(id, obj)
    {
        if(getById(id) == null)
        {
            console.log('объект не найден');
        }
        let tmp = getById(id).obj;
        tmp = Object.assign(tmp, obj);

        this.replaceById(id, tmp);
    }
    replaceById(id, obj)
    {
        if(getById(id) == null)
        {
            console.log('объект не найден');
        }
        else
        {
            collection.set(id, object);
        }
    }
}