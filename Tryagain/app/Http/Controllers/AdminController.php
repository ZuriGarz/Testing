<?php

namespace App\Http\Controllers;

//use App\Models\auth;
use App\Models\User;
use Illuminate\Http\Request;
use Spatie\Permission\Models\Role;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Hash;
use Illuminate\Http\RedirectResponse;
use Spatie\Permission\Models\Permission;


class AdminController extends Controller
{
    public function AdminDashboard(){

        return view('admin.index');
    } //end method

    public function AdminLogout(Request $request): RedirectResponse
    {
        Auth::guard('web')->logout();

        $request->session()->invalidate();

        $request->session()->regenerateToken();

        return redirect('/admin/login');
    } //end method

    public function AdminLogin(){
        return view ('admin.admin_login');
    }

    public function AdminProfile(){
        $id = Auth::user()->id;
        $ProfileData = User::find($id);
        return view ('admin.admin_profile_view', compact('ProfileData'));
    }

    public function AdminProfileStore(Request $request)
    {
        $id = Auth::user()->id;
        $data = User::find($id);

        // Debugging: Print out the values from the form
        // Make sure that $request->email contains a value


        $data->username = $request->username;
        $data->name = $request->name;
        $data->email = $request->email;
        $data->phone = $request->phonenumber;
        $data->address = $request->address;

        if ($request->file('photo')) {
            $file = $request->file('photo');
            @unlink(public_path('upload/admin_images/'.$data->photo));
            $filename = date('YmdHi') . $file->getClientOriginalName('');
            $file->move(public_path('upload/admin_images'), $filename);
            $data['photo'] = $filename;
        }
        $data->save();

        $notification = array(
            'message' => 'Admin Profile update Success',
            'alert-type' => 'success',
        );


        return redirect()->back()->with($notification);
    }

    public function AdminProfileChangePassword(){
        $id = Auth::user()->id;
        $ProfileData = User::find($id);
        return view ('admin.admin_change_password', compact('ProfileData'));
    }


    public function AdminUpdatePassword(Request $request){


        $request->validate([
            'old_password' => 'required',
            'new_password' => 'required|confirmed'
        ]);


        if(!Hash::check($request->old_password, auth::user()->password)){
            $notification = array(
                'message' => 'Old password Mismatch!',
                'alert-type' => 'error'
            );
            return back()->with($notification);

        }

        User::whereId(auth()->user()->id)->update([
            'password' => Hash::make($request->new_password)

        ]);
        $notification = array(
            'message' => 'New password Implemented!',
            'alert-type' => 'success'
        );
        return back()->with($notification);
    }


    public function AllAdminView(){
        $alladmin1 = User::where('role','admin')->get();
        return view('backend.pages.admin.alladmin', compact('alladmin1'));
    }
    public function AddAdmin(){
        $roles = Role::all();
        return view('backend.pages.admin.addadminuser', compact('roles'));
    }
    public function AdminStore(Request $request){

        $user = new User();
        $user->username = $request->username;
        $user->name = $request->name;
        $user->email = $request->email;
        $user->phone = $request->phone;
        $user->address = $request->address;
        $user->password = Hash::make($request->password);
        $user->role = 'admin';
        $user->username = 'active';
        $user->save();

        if ($request->roles){
            $user->AssignRole($request->roles);
        }

        $notification = array (
            'message' => 'Admin Add successfully HEH!',
            'alert_type' => 'success',
        );
        return redirect()->route('admin.all.view')->with($notification);
    }

    public function EditAdmin($id){

        $user = User::findOrFail($id);
        $roles = Role::all();
        return view('backend.pages.admin.editadmin', compact('user', 'roles'));
    }

    public function AdminEditSubmit(Request $request, $id){

        $user = User::findOrFail($id);
        $user->username = $request->username;
        $user->name = $request->name;
        $user->email = $request->email;
        $user->phone = $request->phone;
        $user->address = $request->address;
        $user->role = 'admin';
        $user->username = 'active';
        $user->save();

        $user->roles()->detach();
        if ($request->roles) {
            $user->assignRole($request->roles);
        }

        $notification = array(
            'message' => 'Admin Update successfully HEH!',
            'alert_type' => 'success',
        );
        return redirect()->route('admin.all.view')->with($notification);
    }

    public function DeleteAdmin($id){
        $user = User::findOrFail($id);
        if (!is_null($user)){
            $user->delete();
        }
        $notification = array(
            'message' => 'Admin Delete successfully HEH!',
            'alert_type' => 'warning',
        );
        return redirect()->back()->with($notification);
    }
}
