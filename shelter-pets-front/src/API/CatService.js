import Client from './AxiosClient';
const resource = '/cats';

export default {
    getAll() {
        return Client.get(`${resource}`);
    },
    getOne(id) {
        return Client.get(`${resource}/${id}`);
    },
    create(payload) {
        return Client.post(`${resource}`, payload);
    },
    
    delete(id) {
        return Client.delete(`${resource}/${id}`)
    },

};