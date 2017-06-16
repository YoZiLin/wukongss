import Vue from 'vue';

import store from '../store/index.js';

const loaderControll = Vue.extend(require('./load.vue'));

loaderControll.prototype.show = function() {
    this.visible = true;
}

loaderControll.prototype.hide = function() {
    this.visible = false;
}

const request = (loader) => {
    store.dispatch('setRequestCount', '+');
    if (store.state.requestCount > 0) {
        loader.show();
    }
}

const endRequest = (loader) => {
    store.dispatch('setRequestCount', '-');
    if (store.state.requestCount <= 0) {
        loader.hide();
    }
}



let api = (type) => {
    let loader = new loaderControll({
        el: document.createElement('div')
    });
    let box = document.getElementById('load-box');
    if (!box) {
        document.body.appendChild(loader.$el);
    }
    try {
        request(loader);
    } catch (error) {
        endRequest(loader);
    }
}

export default {
    api,
    install(Vue) {
        Vue.prototype.api = api;
    }
}