import {defineConfig} from 'vite'

export default defineConfig({
    server: {
        watch: {
            ignored: ['**/demo/**/.vs/**', '**/demo/**/bin/**', '**/demo/**/obj/**']
        }
    }
})