// DataServices
import ClientService from '../services/client/client.service';
import StaffService from '../services/staff/staff.service';

class RoleLib {
    isClient(userID) {
        if (ClientService.get(userID)) {
            return true;
        } else {
            return false;
        }
    }

    isStaff(userID) {
        if (StaffService.get(userID)) {
            return true;
        } else {
            return false;
        }
    }
}

export default new RoleLib();