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

                                    <h6 class="card-title">Edit Amenities Data !</h6>

                                    <form method="POST" action="{{ route('update.amemitie') }}" class="forms-sample"
                                        enctype="multipart/form-data" enctype="multipart/form-data">
                                        @csrf
                                        <input type="hidden" name="id" value{{ $amenities->id }}>
                                        <input type="text" hidden name="id" value="{{ $amenities->id }}">
                                        <div class="row mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Edit
                                                Aminities?!</label>
                                            <div class="col-sm-9">
                                                <input type="text" name="amenities_name" class="form-control"
                                                    id="type_amenities" autocomplete="off"
                                                    value="{{ $amenities->amenities_name }}">
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
