import Vue from 'vue';

import store from '../store/index.js';

const loaderControll = Vue.extend(require('./load.vue'));

loaderControll.prototype.show = function() {
    this.visible = true;
}

loaderControll.prototype.hide = function() {
    this.visible = false;
}

const loader = new loaderControll({
    el: document.createElement('div')
});

const request = function() {
    let box = document.getElementById('load-box');
    if (!box) {
        document.body.appendChild(loader.$el);
    }
    store.dispatch('setRequestCount', '+');
    if (store.state.requestCount > 0) {
        loader.show();
    }
}

const endRequest = function() {
    store.dispatch('setRequestCount', '-');
    if (store.state.requestCount <= 0) {
        loader.hide();
    }
}



let api = (type) => {
    try {
        request();
    } catch (error) {
        endRequest();
    }
}

export default {
    api,
    install(Vue) {
        Vue.prototype.api = api;
    }
}