<?php

namespace App\Http\Controllers\Backend;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Models\PropertyType;
use Illuminate\Support\Facades\Auth;
use App\Models\Amenities;

class PropertyTypeController extends Controller
{
    public function AllType()
    {
        $types = PropertyType::latest()->get();
        return view('backend.type.all_type', compact('types'));
    }

    public function AddType()
    {
        // $types = PropertyType::latest()->get();
        return view('backend.type.add_type');
    }

    public function StoreType(Request $request)
    {
        $types = PropertyType::latest()->get();
        $request->validate([
            'type_name' => 'required|unique:property_types|max:200',
            'type_icon' => 'required'
        ]);

        PropertyType::insert([
            'type_name' => $request->type_name,
            'type_icon' => $request->type_icon
        ]);

        $notification = array(
            'message' => 'Property created Successfully',
            'alert-type' => 'success'
        );

        return redirect()->route('all.type')->with($notification);
    }

    public function EditType($id){

        $types = PropertyType::findOrFail($id);
        return view('backend.type.edit_type', compact('types'));

    }

    public function UpdateType(Request $request)
    {
        $pid = $request->id;

        PropertyType::findOrFail($pid)->update([
            'type_name' => $request->type_name,
            'type_icon' => $request->type_icon
        ]);


        $notification = array(
            'message' => 'Property Edited Successfully',
            'alert-type' => 'success'
        );

        return redirect()->route('all.type')->with($notification);
    }

    public function DeleteType($id){
        PropertyType::findOrFail($id)->delete();

        $notification = array(
            'message' => 'Property Delete Successfully',
            'alert-type' => 'success'
        );

        return redirect()->back()->with($notification);
    }

    public function AllAmenitie(){
        $amenities = Amenities::latest()->get();
        return view('backend.amenities.all_amenities', compact('amenities'));
    }

    public function AddAmenitie(){

        return view('backend.amenities.add_amenities');
    }

    public function StoreAmenitie(Request $request){
        // $amenities = Amenities::latest()->get();
        // $request->validate([
        //     'amenities_name' => 'required|unique:property_types|max:200',
        // ]);

        Amenities::insert([
            'amenities_name' => $request->amenities_name,
        ]);

        $notification = array(
            'message' => 'Property created Successfully',
            'alert-type' => 'success'
        );

        return redirect()->route('all.Amenitie')->with($notification);
    }

    public function EditAmenitie($id)
    {

        $amenities = Amenities::findOrFail($id);
        return view('backend.amenities.edit_amenities', compact('amenities'));
    }



    public function UpdateAmemitie(Request $request)
    {
        $ame_id = $request->id; // Corrected assignment

        Amenities::findOrFail($ame_id)->update([
            'amenities_name' => $request->amenities_name,
        ]);

        $notification = array(
            'message' => 'Amenity updated Successfully',
            'alert-type' => 'success'
        );

        return redirect()->route('all.Amenitie')->with($notification);
    }
    public function DeleteAmenitie($id){
        Amenities::findOrFail($id)->delete();

        $notification = array(
            'message' => 'Amenity Delete Successfully',
            'alert-type' => 'success'
        );

        return redirect()->back()->with($notification);
    }
    
}



