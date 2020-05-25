const axios = require('axios').default;

const getAllQueries = async () => {
    let queries = await axios.post('https://localhost:5001/query/1/run', {});
    return queries.data.data;
};

exports.getAllQueries = getAllQueries;