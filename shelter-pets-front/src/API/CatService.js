import Client from './AxiosClient';
const resource = '/cats';

export default {
    getAll() {
        //return Client.get(`${resource}`);

        return [
            {
                catId:     0,
                name:      "Cat 1",
                gender:    "Male",
                age:       "10",
                breed:     "Sphynx",
                shelterId: 0,
            },
            {
                catId: 1,
                name:      "Cat 2",
                gender:    "Male",
                age:       "11",
                breed:     "Serval",
                shelterId: 0,
            }
        ]
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