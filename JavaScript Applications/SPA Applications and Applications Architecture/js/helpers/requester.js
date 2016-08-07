var app = app || {};

app.requester = (function () {
    function Requester(appId, appSecret) {
        this.appId = appId;
        this.appSecret = appSecret;
        this.baseUrl = 'https://baas.kinvey.com/';
    }

    Requester.prototype.get = function (url, useSession) {
        return this.makeRequest('GET', url, null, useSession);
    };

    Requester.prototype.post = function (url, data, useSessiom) {
        return this.makeRequest('POST', url, data, useSessiom);
    };

    Requester.prototype.makeRequest = function (method, url, data, useSession) {
        var token,
            defer = Q.defer(),
            _this = this,
            options = {
                method: method,
                url: url,
                success: function (data) {
                    defer.resolve(data);
                },
                error: function (error) {
                    defer.reject(error);
                }
            };

        $.ajaxSetup({
            beforeSend: function (xhr, settings) {
                xhr.setRequestHeader('Authorization', 'Basic T3RrYWNoZW5pbzoxMjM0NQ==');

                if (data) {
                    xhr.setRequestHeader('Content-Type', 'application/json');
                    settings.data = JSON.stringify(data);
                    return true;
                }
            }
        });

        $.ajax(options);

        return defer.promise;
    };

    return {
        config: function (appId, appSecret) {
            return new Requester(appId, appSecret);
        }
    }
})();