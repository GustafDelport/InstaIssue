// DataServices
import ClientService from '../services/client/client.service';
import StaffService from '../services/staff/staff.service';

class RoleLib {
    async isClient(userID) {
        let flag = false;
        await ClientService.getClient(userID).then(res => {
            if (res.data[0]) {
                flag = true;
            } else {
                flag = false;
            }
        })
        if (flag) {
           // console.log('Client true');
            return true;
        } else {
           // console.log('Client false');
            return false;
        }
    }

    async isStaff(userID) {
        let flag = false;
        await StaffService.getUser(userID).then(res => {
            console.log([res]);
            if (res.data[0]) {
                flag = true;
            } else {
                flag = false;
            }
        })
        if (flag) {
           // console.log('Staff true');
            return true;
        } else {
           // console.log('Staff false');
            return false;
        }
    }
}

export default new RoleLib();