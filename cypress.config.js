const { defineConfig } = require('cypress')

module.exports = defineConfig({
  env: {
        apiUrl: 'http://localhost:5174/api/hobby',
  },
  e2e: {
    setupNodeEvents(on, config) {},
    supportFile: false,
  },
})