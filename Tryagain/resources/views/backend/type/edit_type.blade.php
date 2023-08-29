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

                                    <h6 class="card-title">Edit Type Data !</h6>

                                    <form method="POST" action="{{ route('update.type') }}" class="forms-sample"
                                        enctype="multipart/form-data" enctype="multipart/form-data">
                                        @csrf
                                        <input type="text" hidden name="id" value="{{ $types->id }}">
                                        <div class="row mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Type Name?!</label>
                                            <div class="col-sm-9">
                                                <input type="text" name="type_name" class="form-control @error('type_name') is-invalid @enderror"
                                                    id="type_name" autocomplete="off" value="{{ $types->type_name }}">
                                                    @error('type_name')
                                                        <span class="text-danger">{{ $message }}</span>
                                                    @enderror

                                            </div>
                                        </div>
                                        <div class="row mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Type Icon?!</label>
                                            <div class="col-sm-9">
                                                <input type="text" name="type_icon" class="form-control @error('type_icon') is-invalid @enderror"
                                                    id="type_icon" autocomplete="off" value="{{ $types->type_icon }}">
                                                    @error('type_icon')
                                                        <span class="text-danger">{{ $message }}</span>
                                                    @enderror

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

@endsection

