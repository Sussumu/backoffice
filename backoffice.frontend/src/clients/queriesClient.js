const axios = require('axios').default;

const getAllQueries = async () => {
    let queries = await axios.get('http://localhost:5000/api/query/run/1');
    console.log(queries);
};

exports.getAllQueries = getAllQueries;