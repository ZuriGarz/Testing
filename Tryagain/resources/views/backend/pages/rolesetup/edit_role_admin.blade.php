@extends('admin.admin_dashboard')
@section('admin')
    <!-- partial:../../partials/_navbar.html -->

    <style type="text/css">
        .form-check-label {
            text-transform: capitalize;
        }
    </style>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <div class="page-content">
        <div class="row profile-body">
            <div class="col-md-12 col-xl-22 middle-wrapper">
                <div class="row">
                    <div class="col-md-15 grid-margin">
                        <div class="col-md-10 grid-margin stretch-card">
                            <div class="card">
                                <div class="card-body">

                                    <h6 class="card-title">Edit Roles and Permission!</h6>

                                    <form method="POST" action="{{ route('admin.roles.update', $roles->id) }}" class="forms-sample"
                                        enctype="multipart/form-data" enctype="multipart/form-data" id="myForm">
                                        @csrf
                                        <div class="form-group mb-3">
                                            <label for="oldpassword" class="col-sm-3 col-form-label">Role Name?!</label>
                                            <h3>{{ $roles->name }}</h3>
                                            <div class="col-sm-9">

                                            </div>

                                        </div>


                                        <div class="form-check mb-3">
                                            <input type="checkbox" class="form-check-input" id="checkDefaultmain">
                                            <label class="form-check-label" for="checkDefaultmain">
                                                Permission All
                                            </label>
                                        </div>
                                        <hr>
                                        @foreach ($permission_groups as $group)
                                            <div class="row">
                                                <div class="col-3">
                                                    @php
                                                        $permissions = App\Models\User::getpermissionByGroupName($group->group_name);
                                                    @endphp
                                                    <div class="form-check mb-3">
                                                        <input type="checkbox" class="form-check-input" id="checkDefault"
                                                            name="checkDefault"
                                                            {{ App\Models\User::roleHasPermissions($roles, $permissions) ? 'checked' : '' }}>
                                                        <label class="form-check-label" for="checkDefault">
                                                            {{ $group->group_name }}
                                                        </label>
                                                        <hr>
                                                    </div>
                                                </div>
                                                <div class="col-9">
                                                    @foreach ($permissions as $permission)
                                                        <div class="form-check mb-3">
                                                            <input type="checkbox" class="form-check-input"
                                                                name="permission[]" id="checkDefault{{ $permission->id }}"
                                                                value="{{ $permission->id }}"
                                                                {{ $roles->hasPermissionTo($permission->name) ? 'checked' : '' }}>
                                                            <label class="form-check-label" for="checkDefault">
                                                                {{ $permission->name }}
                                                            </label>
                                                        </div>
                                                    @endforeach
                                                </div>

                                            </div>
                                        @endforeach

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
        $('#checkDefaultmain').click(function() {
            if ($(this).is(':checked')) {
                $('input[ type= checkbox]').prop('checked', true);
            } else {
                $('input[ type= checkbox]').prop('checked', false);
            }
        });
    </script>
@endsection
