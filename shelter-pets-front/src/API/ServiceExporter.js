import CatService from './CatService';
import ShelterService from './ShelterService';

const repositories = {
    'cats': CatService,
    'shelters': ShelterService
}
export default {
    get: name => repositories[name]
};