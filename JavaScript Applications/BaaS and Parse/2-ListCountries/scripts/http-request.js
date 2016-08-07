(function () {   
    this.httpRequest = (function () {
        var getHttpRequest, getJSON, makeRequest, postJSON;
        getHttpRequest = (function () {
            var xmlHttpFactories = [
                function () {
                    return new XMLHttpRequest();
                },
                function () {
                    return new ActiveXObject("Msxml3.XMLHTTP");
                },
                function () {
                    return new ActiveXObject("Msxml2.XMLHTTP.6.0");
                },
                function () {
                    return new ActiveXObject("Msxml2.XMLHTTP.3.0");
                },
                function () {
                    return new ActiveXObject("Msxml2.XMLHTTP");
                },
                function () {
                    return new ActiveXObject("Microsoft.XMLHTTP");
                }
            ];

            return function () {
                var xmlFactory, i, len;

                for (i = 0, len = xmlHttpFactories.length; i < len; i++) {
                    xmlFactory = xmlHttpFactories[i];
                    try {
                        return xmlFactory();
                    } catch (err) {
                    }
                }

                return null;
            }
        })();
        makeRequest = function (options) {
            var httpRequest, requestUrl, type, success, error, contentType, accept, data;
            httpRequest = getHttpRequest();
            options = options || {};
            //extract the values from the options and provide default values for the missing arguments
            requestUrl = options.url;
            type = options.type || 'GET';
            success = options.success || function () { };
            error = options.error || function () { };
            contentType = options.contentType || '';
            accept = options.accept || '';
            data = options.data || null;

            httpRequest.onreadystatechange = function () {
                if (httpRequest.readyState === 4) {
                    switch (Math.floor(httpRequest.status / 100)) {
                        case 2:
                            success(httpRequest.responseText);
                            break;
                        default:
                            error(httpRequest.responseText);
                            break;
                    }
                }
            }

            httpRequest.open(type, requestUrl, true);
            httpRequest.setRequestHeader('Authorization', 'Basic T3RrYWNoZW5pbzoxMjM0NQ==');
            httpRequest.setRequestHeader('Content-Type', contentType);
            httpRequest.setRequestHeader('Accept', accept);

            return httpRequest.send(data);
        }

        return {
            make: makeRequest,         
        }
    })();
}).call(this);