@extends('admin.admin_dashboard')
@section('admin')
    <!-- partial:../../partials/_navbar.html -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <div class="page-content">
        <div class="row profile-body">

            <div class="col-md-8 col-xl-22 middle-wrapper">
                <div class="row">
                    <div class="col-md-15 grid-margin">
                        <div class="col-md-10 grid-margin stretch-card">
                            <div class="card">
                                <div class="card-body">

                                    <h6 class="card-title">Add Permission !</h6>

                                    <form method="POST" action="{{ route('store.permission') }}" class="forms-sample"
                                        enctype="multipart/form-data" enctype="multipart/form-data" id="myForm">
                                        @csrf
                                        <div class="form-group mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Permission Name?!</label>
                                            <div class="col-sm-9">
                                                <input type="text" name="name" class="form-control">
                                            </div>
                                        </div>
                                        <div class="form-group mb-3">
                                            <label for="exampleInputEmail1" class="col-sm-3 col-form-label">Group Name?!</label>
                                            <div class="col-sm-9">
                                                <select name="group_name" class="form-select" id="exampleFormControlSelect1">
                                                    <option selected="" disabled="">Select Group</option>
                                                    <option value="type">Property Type</option>
                                                    <option value="state">State</option>
                                                    <option value="amenities">Amenities</option>
                                                    <option value="property">Property</option>
                                                    <option value="history">Package History</option>
                                                    <option value="message">Property Message</option>
                                                    <option value="testimonials">Testimonials</option>
                                                    <option value="agent">Manage Agent</option>
                                                    <option value="category">Blog Category</option>
                                                    <option value="post">Blog Post</option>
                                                    <option value="comment">Blog Comment</option>
                                                    <option value="smtp">SMTP Setting</option>
                                                    <option value="site">Site Setting</option>
                                                    <option value="comment">Role & Permission</option>
                                                </select>
                                            </div>
                                        </div>
                                        <button type="submit" class="btn btn-outline-primary btn-icon-text mb-2 mb-md-0">
                                            Submit
                                        </button>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function (){
            $('#myForm').validate({
                rules: {
                    amenities_name: {
                        required : true,
                    },

                },
                messages :{
                    amenities_name: {
                        required : 'Please Enter Amenities Name',
                    },


                },
                errorElement : 'span',
                errorPlacement: function (error,element) {
                    error.addClass('invalid-feedback');
                    element.closest('.form-group').append(error);
                },
                highlight : function(element, errorClass, validClass){
                    $(element).addClass('is-invalid');
                },
                unhighlight : function(element, errorClass, validClass){
                    $(element).removeClass('is-invalid');
                },
            });
        });

    </script>
@endsection
