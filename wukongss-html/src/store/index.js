import Vue from 'vue';
import vuex from 'vuex';
import * as state from './state.js';
import * as getters from './getters.js';
import * as actions from './actions.js';
import mutations from './mutations.js';
Vue.use(vuex);

const store = new vuex.Store({
    state,
    getters,
    actions,
    mutations
});

export default store;                                                  