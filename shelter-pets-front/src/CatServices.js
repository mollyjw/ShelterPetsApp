// import Vue from 'vue'
import axios from 'axios'

axios.create({
    baseURL: 'http://localhost:5000/api/cats',
    json: true
})

export default {
    
    getAll() {
        return this.execute('get', '/')
    },
    getById(id) {
        return this.execute('get', `/${id}`)
    },
    create(data) {
        return this.execute('post', '/', data)
    },
    update(id) {
        return this.execute('delete', `/${id}`)
    },
}