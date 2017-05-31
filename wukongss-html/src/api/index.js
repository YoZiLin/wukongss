import Vue from 'vue';

let api = {
    showMessage(str) {
        window.external.ShowMessage(str);
    }
}

export default {
    api,
    install(Vue) {
        Vue.prototype.api = api;
    }
}