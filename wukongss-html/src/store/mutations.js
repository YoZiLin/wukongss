const mutations = {
    setRequestCount(state, type) {
        if (type === '-') {
            state.requestCount--;
        } else if (type === '+') {
            state.requestCount++;
        }
    }
}

export default mutations;