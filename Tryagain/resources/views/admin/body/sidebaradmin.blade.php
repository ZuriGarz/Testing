<!-- partial:partials/_sidebar.html -->
<nav class="sidebar">
    <div class="sidebar-header">
        <a href="#" class="sidebar-brand">
            Admin<span> Dash~</span>
        </a>
        <div class="sidebar-toggler not-active">
            <span></span>
            <span></span>
            <span></span>
        </div>
    </div>
    <div class="sidebar-body">
        <ul class="nav">
            <li class="nav-item nav-category">Main</li>
            <li class="nav-item">
                <a href="{{ route('admin.dashboard') }}" class="nav-link">
                    <i class="link-icon" data-feather="box"></i>
                    <span class="link-title">Dashboard</span>
                </a>
            </li>
            <li class="nav-item nav-category">RealEstate</li>

            @if (Auth::user()->can('type.menu'))
                <li class="nav-item">
                    <a class="nav-link" data-bs-toggle="collapse" href="#emails" role="button" aria-expanded="false"
                        aria-controls="emails">
                        <i class="link-icon" data-feather="mail"></i>
                        <span class="link-title">Property Type</span>
                        <i class="link-arrow" data-feather="chevron-down"></i>
                    </a>
                    <div class="collapse" id="emails">
                        <ul class="nav sub-menu">
                            @if (Auth::user()->can('type.menu'))
                                <li class="nav-item">
                                    <a href="{{ route('all.type') }}" class="nav-link">All Type</a>
                                </li>
                            @endif
                            @if (Auth::user()->can('type.menu'))
                                <li class="nav-item">
                                    <a href="{{ route('add.type') }}" class="nav-link">Add Type</a>
                                </li>
                            @endif
                        </ul>
                    </div>
                </li>
            @endif

            <li class="nav-item">
                <a class="nav-link" data-bs-toggle="collapse" href="#amenitie" role="button" aria-expanded="false"
                    aria-controls="emails">
                    <i class="link-icon" data-feather="mail"></i>
                    <span class="link-title">Amenitie </span>
                    <i class="link-arrow" data-feather="chevron-down"></i>
                </a>
                <div class="collapse" id="amenitie">
                    <ul class="nav sub-menu">
                        <li class="nav-item">
                            <a href="{{ route('all.Amenitie') }}" class="nav-link">All Amenities</a>
                        </li>
                        <li class="nav-item">
                            <a href="{{ route('add.Amenitie') }}" class="nav-link">Add Amenities</a>
                        </li>
                        <li class="nav-item">
                            <a href="{{ route('try.api') }}" class="nav-link"> Google API try</a>
                        </li>
                    </ul>
                </div>
            </li>




            <li class="nav-item">
                <a href="pages/apps/calendar.html" class="nav-link">
                    <i class="link-icon" data-feather="calendar"></i>
                    <span class="link-title">Calendar</span>
                </a>
            </li>
            @if (Auth::user()->can('state.menu'))
                <li class="nav-item nav-category">Admin Management</li>
                <li class="nav-item">
                    <a class="nav-link" data-bs-toggle="collapse" href="#uiComponents" role="button"
                        aria-expanded="false" aria-controls="uiComponents">
                        <i class="link-icon" data-feather="feather"></i>
                        <span class="link-title">AdminThings</span>
                        <i class="link-arrow" data-feather="chevron-down"></i>
                    </a>
                    <div class="collapse" id="uiComponents">
                        <ul class="nav sub-menu">
                            <li class="nav-item">
                                <a href="{{ route('admin.all.view') }}" class="nav-link">All Admins</a>
                            </li>
                            <li class="nav-item">
                                <a href="{{ route('add.admin') }}" class="nav-link">Add Admin</a>
                            </li>

                        </ul>
                    </div>
                </li>

                <li class="nav-item nav-category">Role and Permission</li>
                <li class="nav-item">
                    <a class="nav-link" data-bs-toggle="collapse" href="#advancedUI" role="button"
                        aria-expanded="false" aria-controls="advancedUI">
                        <i class="link-icon" data-feather="anchor"></i>
                        <span class="link-title">Role & Permission</span>
                        <i class="link-arrow" data-feather="chevron-down"></i>
                    </a>
                    <div class="collapse" id="advancedUI">
                        <ul class="nav sub-menu">
                            <li class="nav-item">
                                <a href="{{ route('all.permission') }}" class="nav-link">All Permission</a>
                            </li>
                            <li class="nav-item">
                                <a href="{{ route('all.roles') }}" class="nav-link">All Roles </a>
                            </li>
                            <li class="nav-item">
                                <a href="{{ route('add.roles.permission') }}" class="nav-link">Add Roles in
                                    Permission </a>
                            </li>
                            <li class="nav-item">
                                <a href="{{ route('all.roles.permission') }}" class="nav-link">All Roles in
                                    Permission </a>
                            </li>

                        </ul>
                    </div>
                </li>
            @endif
            <li class="nav-item nav-category">Docs</li>
            <li class="nav-item">
                <a href="https://www.nobleui.com/html/documentation/docs.html" target="_blank" class="nav-link">
                    <i class="link-icon" data-feather="hash"></i>
                    <span class="link-title">Documentation</span>
                </a>
            </li>
        </ul>
    </div>
</nav>
