import Client from './AxiosClient';
const resource = '/cats';

export default {
    getAll() {
        return Client.get(resource).then(response => response.data);
    },
    getOne(id) {
        return Client.get(`${resource}/${id}`).then(response => response.data);
    },
    create(payload) {
        return Client.post(`${resource}`, payload);
    },
    
    delete(id) {
        return Client.delete(`${resource}/${id}`)
    },

};