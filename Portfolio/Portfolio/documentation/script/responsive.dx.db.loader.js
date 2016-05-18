yepnope.insertBeforeElement = document.getElementById('responsive-marker');
switch (getDeviceType()) {
    case "MOBILE":
        Modernizr.load([{
                        load: ['stylesheets/bootstrap.css',
                                'stylesheets/mobile.dx.db.2012.css',
                                'script/responsive.common.min.js',
                                'script/mobile.dx.db.2012.js'],
                        complete: function () {
                            onResponsiveFilesLoaded()
                        }
                        }]);
        break;
    case "TABLET":
        Modernizr.load([{
                        load: ['stylesheets/bootstrap.css',
                                'stylesheets/tablet.dx.db.2012.css',
                                'script/responsive.common.min.js',
                                'script/tablet.dx.db.2012.js'],
                        complete: function () {
                            onResponsiveFilesLoaded()
                        }
                        }]);
        break;
}