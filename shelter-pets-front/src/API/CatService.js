import Client from './AxiosClient';
const resource = '/cats';

export default {
    getAll() {
        return Client.get(resource).then(response => response.data);
    },
    getOne(id) {
        return Client.get(`${resource}/${id}`).then(response => response.data);
    },
    create(cat) {
        return Client.post(`${resource}`, cat);
    },
    
    delete(id) {
        return Client.delete(`${resource}/${id}`)
    },

};