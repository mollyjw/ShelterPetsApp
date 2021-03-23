import Client from './AxiosClient';
const resource = '/shelters';

export default {
    get() {
        return Client.get(`${resource}`);
    },
    getPost(id) {
        return Client.get(`${resource}/${id}`);
    },
    create(payload) {
        return Client.post(`${resource}`, payload);
    },
    
    delete(id) {
        return Client.delete(`${resource}/${id}`)
    },

};