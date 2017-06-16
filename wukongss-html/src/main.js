// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue';
import App from './App';
import router from './router';
import MuseUI from 'muse-ui';
import '../static/muse-ui/muse-ui.css';
import '../static/muse-ui/theme-carbon.css'; // 使用 carbon 主题(可更改)
import api from '@/api';
import store from './store';
Vue.use(MuseUI);
Vue.use(api);

Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
    el: '#app',
    router,
    store,
    template: '<App/>',
    components: { App }
})