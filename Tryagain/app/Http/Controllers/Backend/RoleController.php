<?php

namespace App\Http\Controllers\Backend;

use App\Models\User;
use Illuminate\Http\Request;
use App\Exports\PermissionExport;
use App\Imports\PermissionImport;
use Illuminate\Support\Facades\DB;
use Spatie\Permission\Models\Role;
use App\Http\Controllers\Controller;
use Maatwebsite\Excel\Facades\Excel;
use Spatie\Permission\Models\Permission;

class RoleController extends Controller
{

    // Permission Controller

    public function AllPermission(){
        $permissions = Permission::all();
        return view('backend.pages.permission.permission_all_permission', compact('permissions'));
    }

    public function AddPermission(){
        return view('backend.pages.permission.addpermission');
    }

    public function StorePermission(Request $request){
        $permission = Permission::create([
            'name' => $request->name ,
            'group_name' => $request->group_name ,
        ]);
        $notification = array(
            'message' => 'Permission Create Succesfully',
            'alert_type' => 'success'
        );
        return redirect()->route('all.permission')->with($notification);
    }
    public function EditPermission($id){
        $permission = Permission::findOrFail($id);
        return view('backend.pages.permission.editpermission', compact('permission'));
    }
    public function UpdatePermission(Request $request){

        $per_id = $request->id; // Corrected assignment

        Permission::findOrFail($per_id)->update([
            'name' => $request->name,
            'group_name' => $request->group_name,
        ]);

        $notification = array(
            'message' => 'Permission updated Successfully',
            'alert-type' => 'success'
        );

        return redirect()->route('all.permission')->with($notification);
    }
    public function DeletePermission($id){
        Permission::findOrFail($id)->delete();

        $notification = array(
            'message' => 'Permission Delete Successfully',
            'alert-type' => 'success'
        );

        return redirect()->back()->with($notification);
    }


    public function ImportPermission()
    {
        return view('backend.pages.permission.importpermission');
    }

    public function Export(){
        return Excel::download(new PermissionExport, 'permission.xlsx');
    }
    public function Import(Request $request){

        Excel::import(new PermissionImport, $request->file('import-file'));

        $notification = array(
            'message' => 'Permission Imported Succesfully',
            'alert_type' => 'success'
        );

        return redirect()->route('all.permission')->with($notification);
    }


    //// Role All Method

    public function AllRoles(){
        $roles = Role::all();
        return view('backend.pages.roles.all_roles', compact('roles'));
    }

    public function AddRoles(){
        return view('backend.pages.roles.add_roles');
    }

    public function StoreRoles(Request $request){
        Role::create([
            'name' => $request->name,
        ]);
        $notification = array(
            'message' => 'Roles Create Succesfully',
            'alert_type' => 'success'
        );
        return redirect()->route('all.roles')->with($notification);
    }

    public function EditRoles($id){
        $roles = Role::findOrFail($id);
        return view('backend.pages.roles.editroles', compact('roles'));
    }

    public function UpdateRoles(Request $request){
        $rol_id = $request->id; // Corrected assignment

        Role::findOrFail($rol_id)->update([
            'name' => $request->name,
        ]);

        $notification = array(
            'message' => 'Roles updated Successfully',
            'alert-type' => 'success'
        );

        return redirect()->route('all.roles')->with($notification);
    }

    public function DeleteRoles($id){
        Role::findOrFail($id)->delete();

        $notification = array(
            'message' => 'Roles Delete Successfully',
            'alert-type' => 'success'
        );

        return redirect()->back()->with($notification);
    }


    //ROLES IN PERMISSIONS wkaokrofsdjbfdvndl;al


    public function AddRolesPermission(){
        $roles = Role::all();
        $permission = Permission::all();
        $permission_groups = User::getpermissionGroups();
        return view('backend.pages.rolesetup.add_role_permission', compact('roles', 'permission', 'permission_groups'));
    }

    public function RolePermissionStore(Request $request){
        $data = array();
        $permission = $request->permission;

        foreach($permission as $key => $item){
            $data['role_id'] = $request->role_id;
            $data['permission_id'] = $item;

            DB::table('role_has_permissions')->insert($data);

        }
        $notification = array(
            'message' => 'Role has Permission is added Succesfully',
            'alert_type' => 'success'
        );
        return redirect()->route('all.roles.permission')->with($notification);

    }

    public function AllRolesPermission(){
        $roles = Role::all();
        return view('backend.pages.rolesetup.all_role_permission', compact('roles'));
    }

    public function AdminEditRoles($id){

        $roles = Role::findOrFail($id);
        $permission = Permission::all();
        $permission_groups = User::getpermissionGroups();
        return view('backend.pages.rolesetup.edit_role_admin', compact('roles', 'permission', 'permission_groups'));
    }

    public function AdminRolesUpdate(Request $request, $id)
    {
        $role = Role::findOrFail($id);
        $permissions = $request->input('permission'); // Corrected line
        if (!empty($permissions)) {
            $role->syncPermissions($permissions);

        }
        $notification = array(
            'message' => 'Role Permission Update Succesfully',
            'alert_type' => 'success'
        );
        return redirect()->route('all.roles.permission')->with($notification);
    }

    public function DeleteRoleAdmin($id){
        $role = Role::findOrFail($id);
        if(!is_null($role)){
            $role->delete();
        }
        $notification = array(
            'message' => 'Role Permission Delete Succesfully',
            'alert_type' => 'success'
        );
        return redirect()->back()->with($notification);
    }

}
