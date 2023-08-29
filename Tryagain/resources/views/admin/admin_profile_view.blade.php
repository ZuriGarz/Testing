@extends('admin.admin_dashboard')
@section('admin')
    <!-- partial:../../partials/_navbar.html -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <div class="page-content">
        <div class="row profile-body">
            <!-- left wrapper start -->
            <div class="d-none d-md-block col-md-6 col-xl-4 left-wrapper">
                <div class="card rounded">
                    <div class="card-body">
                        <div class="d-flex align-items-center justify-content-between mb-2">
                            <div>
                                <img class="wd-90 rounded-circle"
                                    src="{{ !empty($ProfileData->photo) ? url('upload/admin_images/' . $ProfileData->photo) : url('upload/admin_images/Logo.png') }}"
                                    alt="profile">
                                <span class="h4 ms-3 text-light">{{ $ProfileData->username }}</span>
                            </div>
                            <div class="dropdown">
                                <a type="button" id="dropdownMenuButton" data-bs-toggle="dropdown" aria-haspopup="true"
                                    aria-expanded="false">
                                    <i class="icon-lg text-muted pb-3px" data-feather="more-horizontal"></i>
                                </a>
                                <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                                    <a class="dropdown-item d-flex align-items-center" href="javascript:;"><i
                                            data-feather="edit-2" class="icon-sm me-2"></i> <span
                                            class="">Edit</span></a>
                                    <a class="dropdown-item d-flex align-items-center" href="javascript:;"><i
                                            data-feather="git-branch" class="icon-sm me-2"></i> <span
                                            class="">Update</span></a>
                                    <a class="dropdown-item d-flex align-items-center" href="javascript:;"><i
                                            data-feather="eye" class="icon-sm me-2"></i> <span class="">View
                                            all</span></a>
                                </div>
                            </div>
                        </div>
                        <p>Hi! I'm Amiah the Senior UI Designer at NobleUI. We hope you enjoy the design and quality of
                            Social.</p>
                        <div class="mt-3">
                            <label class="tx-11 fw-bolder mb-0 text-uppercase">Name:</label>
                            <p class="text-muted">{{ $ProfileData->name }}</p>
                        </div>
                        <div class="mt-3">
                            <label class="tx-11 fw-bolder mb-0 text-uppercase">Email:</label>
                            <p class="text-muted">{{ $ProfileData->email }}</p>
                        </div>
                        <div class="mt-3">
                            <label class="tx-11 fw-bolder mb-0 text-uppercase">Phone:</label>
                            <p class="text-muted">{{ $ProfileData->phone }}</p>
                        </div>
                        <div class="mt-3">
                            <label class="tx-11 fw-bolder mb-0 text-uppercase">address:</label>
                            <p class="text-muted">{{ $ProfileData->address }}</p>
                        </div>
                        <div class="mt-3 d-flex social-links">
                            <a href="javascript:;" class="btn btn-icon border btn-xs me-2">
                                <i data-feather="github"></i>
                            </a>
                            <a href="javascript:;" class="btn btn-icon border btn-xs me-2">
                                <i data-feather="twitter"></i>
                            </a>
                            <a href="javascript:;" class="btn btn-icon border btn-xs me-2">
                                <i data-feather="instagram"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <!-- left wrapper end -->
            <!-- middle wrapper start -->
            <div class="col-md-8 col-xl-22 middle-wrapper">
                <div class="row">
                    <div class="col-md-15 grid-margin">
                        <div class="col-md-10 grid-margin stretch-card">
                            <div class="card">
                                <div class="card-body">

                                    <h6 class="card-title">Update Admin Profile !</h6>

                                    <form method="POST" action="{{ route('admin.profile.store') }}" class="forms-sample" enctype="multipart/form-data">
                                        @csrf
                                        <div class="row mb-3">
                                            <label for="exampleInputUsername2"
                                                class="col-sm-3 col-form-label">Username</label>
                                            <div class="col-sm-9">
                                                <input type="text" name="username" class="form-control"
                                                    id="exampleInputUsername2" placeholder="Email"
                                                    value="{{ $ProfileData->username }}">
                                            </div>
                                        </div>
                                        <div class="row mb-3">
                                            <label for="exampleInputEmail2" class="col-sm-3 col-form-label">Name</label>
                                            <div class="col-sm-9">
                                                <input type="text" name="name" class="form-control"
                                                    id="exampleInputUsername2" placeholder="Email"
                                                    value="{{ $ProfileData->name }}">
                                            </div>
                                        </div>
                                        <div class="row mb-3">
                                            <label for="exampleInputEmail2" class="col-sm-3 col-form-label">Email</label>
                                            <div class="col-sm-9">
                                                <input type="Email" name="email" class="form-control"
                                                    id="exampleInputUsername2" placeholder="Email"
                                                    value="{{ $ProfileData->email }}">
                                            </div>
                                        </div>
                                        <div class="row mb-3">
                                            <label for="exampleInputMobile" class="col-sm-3 col-form-label">Mobile</label>
                                            <div class="col-sm-9">
                                                <input type="number" name="PhoneNumber" class="form-control"
                                                    id="exampleInputUsername2" placeholder="PhoneNumber"
                                                    value="{{ $ProfileData->phone }}">
                                            </div>
                                        </div>
                                        <div class="row mb-3">
                                            <label for="exampleInputPassword2"
                                                class="col-sm-3 col-form-label">Password</label>
                                            <div class="col-sm-9">
                                                <input type="password" name="password" class="form-control"
                                                    id="exampleInputPassword2" autocomplete="off" placeholder="Password"
                                                    value="{{ $ProfileData->password }}">
                                            </div>
                                        </div>
                                        <div class="mb-3">
                                            <label for="exampleInputUsername2"
                                                class="col-sm-3 col-form-label">Photo</label>
                                        </div>
                                                <div>
                                                    <img class="wd-70 rounded-circle" id="showImage"
                                                        src="{{ !empty($ProfileData->photo) ? url('upload/admin_images/' . $ProfileData->photo) : url('upload/admin_images/Logo.png') }}"
                                                        alt="profile">

                                                </div>

                                                <div class="mb-3">
                                                    <label class="form-label" for="formFile">Photo upload</label>
                                                    <input class="form-control" name="photo" type="file"
                                                        id="Image">
                                                </div>

                                                <button type="submit" class="btn btn-primary me-2">Submit</button>
                                                <button class="btn btn-secondary">Cancel</button>
                                    </form>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- middle wrapper end -->
            <!-- right wrapper start -->

        </div>
    </div>

    <script type="text/javascript">
    $(document).ready(function(){
        $('#Image').change(function(e){
            var reader = new FileReader();
            reader.onload = function(e){
                $('#showImage').attr('src', e.target.result);
            }
            reader.readAsDataURL(e.target.files[0]);
        });
    });
    </script>
@endsection






{{-- Check --}}

