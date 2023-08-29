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

                                    <h6 class="card-title">Add Admins !</h6>

                                    <form method="POST" action="{{ route('store.admin') }}" class="forms-sample"
                                        enctype="multipart/form-data" enctype="multipart/form-data" id="myForm">
                                        @csrf
                                        <div class="form-group mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Admin
                                                Username?!</label>
                                            <div class="col-sm-9">
                                                <input type="text" name="username" class="form-control">
                                            </div>
                                        </div>

                                        <div class="form-group mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Name?!</label>
                                            <div class="col-sm-9">
                                                <input type="text" name="name" class="form-control">
                                            </div>
                                        </div>

                                        <div class="form-group mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Admin Email?!</label>
                                            <div class="col-sm-9">
                                                <input type="email" name="email" class="form-control">
                                            </div>
                                        </div>

                                        <div class="form-group mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Admin Phone?!</label>
                                            <div class="col-sm-9">
                                                <input type="text" name="phone" class="form-control">
                                            </div>
                                        </div>

                                        <div class="form-group mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Admin Address?!</label>
                                            <div class="col-sm-9">
                                                <input type="text" name="address" class="form-control">
                                            </div>
                                        </div>

                                        <div class="form-group mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Admin Password?!</label>
                                            <div class="col-sm-9">
                                                <input type="password" name="password" class="form-control">
                                            </div>
                                        </div>

                                        <div class="form-group mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Role name?!</label>
                                            <select name="roles" class="form-select" id="exampleFormControlSelect1">
                                                <option selected="" disabled="">Select Role</option>
                                                @foreach ($roles as $roles)
                                                    <option value="{{ $roles->id }}">{{ $roles->name }}</option>
                                                @endforeach
                                            </select>
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
        $(document).ready(function() {
            $('#myForm').validate({
                rules: {
                    amenities_name: {
                        required: true,
                    },

                },
                messages: {
                    amenities_name: {
                        required: 'Please Enter Roles Name',
                    },


                },
                errorElement: 'span',
                errorPlacement: function(error, element) {
                    error.addClass('invalid-feedback');
                    element.closest('.form-group').append(error);
                },
                highlight: function(element, errorClass, validClass) {
                    $(element).addClass('is-invalid');
                },
                unhighlight: function(element, errorClass, validClass) {
                    $(element).removeClass('is-invalid');
                },
            });
        });
    </script>
@endsection
