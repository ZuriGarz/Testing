@extends('admin.admin_dashboard')
@section('admin')
    <!-- partial:../../partials/_navbar.html -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <div class="page-content">
        <ol class="breadcrumb">
            <td> <a href="{{ route('export') }}" class="btn btn-inverse-warning">Download Excel File?</a></td> &nbsp; &nbsp; &nbsp;
        </ol>
        <div class="row profile-body">
            <div class="col-md-8 col-xl-22 middle-wrapper">
                <div class="row">
                    <div class="col-md-15 grid-margin">
                        <div class="col-md-10 grid-margin stretch-card">
                            <div class="card">
                                <div class="card-body">

                                    <h6 class="card-title">Import Permission !</h6>

                                    <form method="POST" action="{{ route('import') }}" class="forms-sample"
                                        enctype="multipart/form-data" enctype="multipart/form-data" id="myForm">
                                        @csrf
                                        <div class="form-group mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">XLsx file importo
                                                ?!</label>
                                            <div class="col-sm-9">
                                                <input type="file" name="import-file" class="form-control">
                                            </div>
                                        </div>
                                        <div class="form-group mb-3">
                                            <label for="exampleInputEmail1" class="col-sm-3 col-form-label">Group
                                                Name?!</label>

                                        </div>
                                        <button type="submit" class="btn btn-outline-primary btn-icon-text mb-2 mb-md-0">
                                            Upload
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
